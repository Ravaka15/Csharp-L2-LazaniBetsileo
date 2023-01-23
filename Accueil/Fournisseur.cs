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
    public partial class Fournisseur : Form
    {
        public Fournisseur()
        {
            InitializeComponent();
        }
        Mydatabase db = new Mydatabase();
        //Importer classe fournisseur
        FournisseurDAO fournisseur = new FournisseurDAO();

        private void Fournisseur_Load(object sender, EventArgs e)
        {
            chargertableauFrs();
        }

        //Creation de la fonction d'affichage fournisseur
        private void chargertableauFrs()
        {
            dataGridViewFournisseur.DataSource = getFournisseurs();
        }
        //Affichage Fournisseur
        private object getFournisseurs()
        {
           MySqlCommand cmd = new MySqlCommand(" SELECT* FROM `fournisseur`",db.getConnection);
           db.openConnection();
           MySqlDataReader reader = cmd.ExecuteReader();
           DataTable table = new DataTable();
           table.Load(reader);
           return table;
        }
        //bouton ajou fournisseur
        private void btnAjoutFournisseur_Click(object sender, EventArgs e)
        {
            //creation variable
            string nomFrs = txtNomFrs.Text.Trim();
            string prenomFrs = txtPrenomFrs.Text.Trim();
            string adresseFrs = txtAdresseFrs.Text.Trim();
            string telFrs = txtTelFrs.Text.Trim();

            if (fournisseur.AjoutFournisseur(nomFrs, prenomFrs, adresseFrs, telFrs))
            {
                MessageBox.Show("Fournisseur enregistrer avec succes", "Ajouter fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur d'ajout fournisseuer","Ajouter Fournisseur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //bouton modifier fournisseur
        private void btnModifierFournisseur_Click(object sender, EventArgs e)
        {
            //creation variable
            int idFrs = Convert.ToInt32(txtIdFrs.Text.Trim());
            string nomFrs = txtNomFrs.Text.Trim();
            string prenomFrs = txtPrenomFrs.Text.Trim();
            string adresseFrs = txtAdresseFrs.Text.Trim();
            string telFrs = txtTelFrs.Text.Trim();

            if (fournisseur.ModifierFournisseur(idFrs,nomFrs, prenomFrs, adresseFrs, telFrs))
            {
                MessageBox.Show("Fournisseur modifier avec succes", "Modifier fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur de modification fournisseuer", "Modifier Fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //bouton supprimer fournisseur
        private void btnSupprimerFournisseur_Click(object sender, EventArgs e)
        {
            //creation variable
            int idFrs = Convert.ToInt32(txtIdFrs.Text.Trim());

            if (fournisseur.SupprimerFournisseur(idFrs))
            {
                MessageBox.Show("Fournisseur supprime avec succes", "Supprimer Fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                txtNomFrs.Text = "";
                txtPrenomFrs.Text = "";
                txtAdresseFrs.Text = "";
                txtTelFrs.Text = "";
                MessageBox.Show("Erreur de suppresion Fournisseur", "Supprimer Fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //bouton actualiser fournisseur
        private void btnActualiserFournisseur_Click(object sender, EventArgs e)
        {
            chargertableauFrs();
        }

        //Click tableau 
        private void dataGridViewFournisseur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView selGrid = (DataGridView)sender;
            try
            {
                if (dataGridViewFournisseur.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txtIdFrs.Text = (dataGridViewFournisseur.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtNomFrs.Text = (dataGridViewFournisseur.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txtPrenomFrs.Text = (dataGridViewFournisseur.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtAdresseFrs.Text = (dataGridViewFournisseur.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txtTelFrs.Text = (dataGridViewFournisseur.Rows[e.RowIndex].Cells[4].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("table vide ou " + ex);
            }
        }

        // fonction importe recherche fournisseur
        private void txtChercheFournisseur_TextChanged(object sender, EventArgs e)
        {
            rechercheFournisseur(txtChercheFournisseur.Text.Trim());
        }
        //recherche fournisseur
        private void rechercheFournisseur(string fournisseur)
        {
            DataTable table = new DataTable();

            MySqlCommand cmd = new MySqlCommand("SELECT `IdFrs`, `NomFrs`, `PrenomFrs`, `AdresseFrs`, `TelephoneFrs` FROM `fournisseur` WHERE CONCAT(fournisseur.IdFrs,fournisseur.NomFrs,fournisseur.PrenomFrs,fournisseur.AdresseFrs) LIKE '%" + fournisseur + "%'", db.getConnection);
            db.openConnection();

            MySqlDataReader reader = cmd.ExecuteReader();

            table.Load(reader);

            dataGridViewFournisseur.DataSource = table;
        }
    }
}
