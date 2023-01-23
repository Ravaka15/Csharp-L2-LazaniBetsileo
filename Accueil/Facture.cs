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
    public partial class Facture : Form
    {
        public Facture()
        {
            InitializeComponent();
            chargertableauAchats();
        }
        //Importer classe mere database
        Mydatabase db = new Mydatabase();

        private void Facture_Load(object sender, EventArgs e)
        {

        }
        //Charger tableau Client
        private void chargertableauAchats()
        {
            dataGridViewAchats.DataSource = getAchats();
        }

        private object getAchats()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT  client.IdCli,client.NomCli,produit.Refprod,produit.Nomprod,commande.QttCom,commande.DateCom FROM commande INNER JOIN client INNER JOIN produit produit on commande.IdCli=client.IdCli and commande.Refprod=commande.Refprod", db.getConnection);
            db.openConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return table;
        }

        private void btnActualiserFournisseur_Click(object sender, EventArgs e)
        {

        }

    }
}
