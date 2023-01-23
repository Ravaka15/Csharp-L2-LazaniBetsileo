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
    public partial class Achats : Form
    {
        public Achats()
        {
            InitializeComponent();
        }
        //Importer classe mere database
        Mydatabase db = new Mydatabase();

        //Importer classe fournisseur
        AchatsDAO achats = new AchatsDAO();

        //Importer classe fournisseur
        ProduitDAO produit = new ProduitDAO();

        //Importer classe fournisseur
        ClientDAO client = new ClientDAO();
      
        private void Achats_Load(object sender, EventArgs e)
        {
            //Importer la fonction d"affichage Client
            chargertableauCliCom();

            //Importer la fonction d"affichage Achat
            chargertableauAchats();
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

        //Charger tableau Client
        private void chargertableauCliCom()
        {
            dataGridViewClient.DataSource = getClients();
        }

        private object getClients()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT IdCli,NomCli FROM `client`", db.getConnection);

            db.openConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return table;
        }

        //Click Client
        private void dataGridViewClient_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView selGrid = (DataGridView)sender;
            try
            {
                if (dataGridViewClient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txtIdCli.Text = (dataGridViewClient.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtNomCli.Text = (dataGridViewClient.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("table vide ou " + ex);
            }
        }

        private void pictureBoxPannier_Click(object sender, EventArgs e)
        {
            if (txtIdCli.Text == "" || txtNomCli.Text == "")
            {
                MessageBox.Show("Selectionner un Client", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Pannier pannier = new Pannier(txtIdCli.Text, txtNomCli.Text);
                pannier.ShowDialog();

                //vider champs
                txtIdCli.Text = ""; 
                txtNomCli.Text = "";
            }
        }

        //Creation fonction rechrcher client
        private void txtChercheClient_TextChanged(object sender, EventArgs e)
        {
            rechercheClients(txtChercheClientAchat.Text.Trim());
        }
        // rechreche Client
        private void rechercheClients(string client)
        {
            DataTable table = new DataTable();

            MySqlCommand cmd = new MySqlCommand("SELECT `IdCli`, `NomCli` FROM `client` WHERE CONCAT(client.IdCli,client.NomCli) LIKE '%" + client + "%'", db.getConnection);
            db.openConnection();

            MySqlDataReader reader = cmd.ExecuteReader();

            table.Load(reader);

            dataGridViewClient.DataSource = table;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}





/*Fonction pour ajout des produit
public void ajoutPannier(int idCom, int refprod, int idCli, string nomProd, string nomCli, int qttCom)
{
    pannier = new Achats();
        
}*/