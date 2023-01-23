using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accueil
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            compteProduit();
            compteClient();
            compteFournisseur();
            labelClient.Text = compteClient().ToString();
            labelProduit.Text = compteProduit().ToString();
            labelFournisseur.Text = compteFournisseur().ToString();
        }

        

        //Importer classe fournisseur
        ProduitDAO produit = new ProduitDAO();

        //Importer classe fournisseur
        ClientDAO client = new ClientDAO();
        private object getCount(int x)
        {
            //Importer la classe mere
            Mydatabase db = new Mydatabase();
            MySqlCommand cmd = new MySqlCommand("SELECT SUM(QttCom) as NombreProduitVendu FROM `commande` WHERE MONTH(DateCom)='"+x+"'", db.getConnection);
            db.openConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            Object ob = new Object();
            reader.Read();
            ob = reader.GetValue(0);
            return ob;
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            //Importer la classe mere
            Mydatabase db = new Mydatabase();
            //titre 
            chart.Titles.Add("Titre").Text = "Nombre de produit vendu par mois";
            chart.Titles[0].ForeColor = Color.MediumTurquoise;
            chart.Titles[0].BackColor = Color.White;
            chart.Titles[0].Font = new Font("Time New Roman", 12, FontStyle.Bold);
            compteProduit();
            List<string> x = new List<string>();
            for (int mois = 1; mois < 12;mois++ )
            {
                 chart.Series[0].Points.AddXY(mois, getCount(mois));
                 db.closeConnection();
            }


              
          /*  chart.Series[0].Points.AddXY("Mars");
            chart.Series[0].Points.AddXY("Avril");
            chart.Series[0].Points.AddXY("Mai");
            chart.Series[0].Points.AddXY("Juin");
            chart.Series[0].Points.AddXY("Juillet");
            chart.Series[0].Points.AddXY("Auot");
            chart.Series[0].Points.AddXY("Septembre");
            chart.Series[0].Points.AddXY("Octobre");
            chart.Series[0].Points.AddXY("Novenbre");
            chart.Series[0].Points.AddXY("Decembre");
       */ }


        //Creation de fonction de nombre de produit qui existe
        private Object compteClient()
        {
            //Importer la classe mere
            Mydatabase db = new Mydatabase();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) as NombreClient FROM client", db.getConnection);
            db.openConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            Object ob = new Object();
            reader.Read();
            ob = reader.GetValue(0);
            return ob;
            
        }

        //Creation de fonction de nombre de produit qui existe
        private Object compteProduit()
        {
            //Importer la classe mere
            Mydatabase db = new Mydatabase();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM produit", db.getConnection);
            db.openConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            Object ob = new Object();
            reader.Read();
            ob = reader.GetValue(0);
            return ob;

        }

        //Creation de fonction de nombre de produit qui existe
        private Object compteFournisseur()
        {
            //Importer la classe mere
            Mydatabase db = new Mydatabase();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) as NombreClient FROM fournisseur", db.getConnection);
            db.openConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            Object ob = new Object();
            reader.Read();
            ob = reader.GetValue(0);
            return ob;

        }
    }
}
