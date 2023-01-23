using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Accueil
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();

        }
        //Importeer la classse mere data
        Mydatabase db = new Mydatabase();

        //Importer classe fournisseur
        ClientDAO client = new ClientDAO();

        private void Client_Load(object sender, EventArgs e)
        {
            //Importer la fonction d"affichage Client
            chargertableauCli();
        }

        //Creation de la fonction d'affichage Client
        private void chargertableauCli()
        {
            dataGridViewClient.DataSource = getClients();
        }

        private object getClients()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT* FROM `client`", db.getConnection);

            db.openConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return table;
        }

        // bouton ajout Client
        private void btnAjoutClient_Click(object sender, EventArgs e)
        {
            //creation variable
            string nomCli = txtNomCli.Text.Trim();
            string prenomCli = textPrenomCli.Text.Trim();
            string adresseCli = txtAdresseCli.Text.Trim();
            string telCli = txtTelCli.Text.Trim();
            string villeCli = txtVilleCli.Text.Trim();
            string cinCli = txtCinCli.Text.Trim();

            if (client.AjoutClient(nomCli, prenomCli, adresseCli, telCli, villeCli,cinCli))
            {
                MessageBox.Show("Client enregistrer avec succes", "Ajouter Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur d'ajout Client", "Ajouter Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // bouton modifieer Client
        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            //creation variable
            int idCli = Convert.ToInt32(txtIdCli.Text.Trim());
            string nomCli = txtNomCli.Text.Trim();
            string prenomCli = textPrenomCli.Text.Trim();
            string adresseCli = txtAdresseCli.Text.Trim();
            string telCli = txtTelCli.Text.Trim();
            string villeCli = txtVilleCli.Text.Trim();
            string cinCli = txtCinCli.Text.Trim();

            if (client.ModifierClient(idCli,nomCli, prenomCli, adresseCli, telCli, villeCli, cinCli))
            {
                MessageBox.Show("Client modifier avec succes", "Modifier Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur de modification Client", "Modifier Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // bouton supprimer Client
        private void btnSupprimerClent_Click(object sender, EventArgs e)
        {
             //creation variable
            int idCli = Convert.ToInt32(txtIdCli.Text.Trim());
           
            if (client.SupprimerClient(idCli))
            {
                MessageBox.Show("Client supprime avec succes", "Supprimer Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                txtNomCli.Text = "";
                textPrenomCli.Text = "";
                txtAdresseCli.Text = "";
                txtTelCli.Text = "";
                txtCinCli.Text = "";
                txtVilleCli.Text = "";
                txtIdCli.Text = "";
                MessageBox.Show("Erreur de suppresion Client", "Supprimer Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //bouton actualiser
        private void btnActualiserClient_Click(object sender, EventArgs e)
        {
            chargertableauCli();
        }

        // creation fonction rechreche Client
        private void txtChercheClient_TextChanged(object sender, EventArgs e)
        {
            rechercheClients(txtChercheClient.Text.Trim());
        }

        // rechreche Client
        private void rechercheClients(string client)
        {
            DataTable table = new DataTable();

            MySqlCommand cmd = new MySqlCommand("SELECT `IdCli`, `NomCli`, `PrenomCli`, `AdresseCli`, `TelephoneCli`, `VilleCli`, `CIN` FROM `client` WHERE CONCAT(client.IdCli,client.NomCli,client.PrenomCli,client.AdresseCli,client.VilleCli) LIKE '%" + client + "%'", db.getConnection);
            db.openConnection();

            MySqlDataReader reader = cmd.ExecuteReader();

            table.Load(reader);

            dataGridViewClient.DataSource = table;
        }

        // Click tableau 
        private void dataGridViewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView selGrid = (DataGridView)sender;
            try
            {
                if (dataGridViewClient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txtIdCli.Text = (dataGridViewClient.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtNomCli.Text = (dataGridViewClient.Rows[e.RowIndex].Cells[1].Value.ToString());
                    textPrenomCli.Text = (dataGridViewClient.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtAdresseCli.Text = (dataGridViewClient.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txtTelCli.Text = (dataGridViewClient.Rows[e.RowIndex].Cells[4].Value.ToString());
                    txtVilleCli.Text = (dataGridViewClient.Rows[e.RowIndex].Cells[5].Value.ToString());
                    txtCinCli.Text = (dataGridViewClient.Rows[e.RowIndex].Cells[6].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("table vide ou " + ex);
            }
        }


        //text numerique
        private void txtTelCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


        //text numerique
        private void txtCinCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            //text numerique
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
