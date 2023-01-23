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
    public partial class Livraison : Form
    {
        public Livraison()
        {
            InitializeComponent();
        }

        //Importer classe mere database
        Mydatabase db = new Mydatabase();

        //Importer classe fournisseur
        LivraisonDAO livraison = new LivraisonDAO();

        private void Livraison_Load(object sender, EventArgs e)
        {
            //Importer la fonction d"affichage Fournisseur
            chargertableauFournisseurliv();

            //Importer la fonction d'affichage fournisseur
            chargertableauLivraison();
        }


        //Charger tableau Fournisseur
        private void chargertableauFournisseurliv()
        {
            dataGridViewFrsLiv.DataSource = getFournisseurs();
        }

        private object getFournisseurs()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT IdFrs,NomFrs FROM `fournisseur`", db.getConnection);

            db.openConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return table;
        }

        //Charger tableau Livraison
        private void chargertableauLivraison()
        {
            dataGridViewLivraison.DataSource = getLivraison();
        }

        private object getLivraison()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT  fournisseur.IdFrs,fournisseur.NomFrs,produit.Refprod,produit.Nomprod,livrer.QttLiv,livrer.DateLiv FROM livrer INNER JOIN fournisseur INNER JOIN produit on livrer.IdFrs=fournisseur.IdFrs", db.getConnection);
            db.openConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return table;
        }
        //clikc tableau fournisseur
        private void dataGridViewFrsLiv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView selGrid = (DataGridView)sender;
            try
            {
                if (dataGridViewFrsLiv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txtIdFrs.Text = (dataGridViewFrsLiv.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtNomFrs.Text = (dataGridViewFrsLiv.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("table vide ou " + ex);
            }
        }

        //Importer la fonction recherch fournisseur
        private void txtChercheFournisseurLi_TextChanged(object sender, EventArgs e)
        {
            rechercheFournisseur(txtChercheFournisseurLi.Text.Trim());
        }

        //recherche fournisseur
        private void rechercheFournisseur(string f)
        {
            DataTable table = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT `IdFrs`, `NomFrs` FROM `fournisseur` WHERE CONCAT(fournisseur.IdFrs,fournisseur.NomFrs) LIKE '%" + f + "%'", db.getConnection);
            db.openConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader);
            dataGridViewFrsLiv.DataSource = table;
        }

        //bouton ouvrir Le livreeaison 
        private void pictureBoxPannier_Click(object sender, EventArgs e)
        {
            if (txtIdFrs.Text == "" || txtNomFrs.Text == "")
            {
                MessageBox.Show("Selectionner un Fournisseur", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string x = txtIdFrs.Text;
                string y = txtNomFrs.Text;
                LivraisonDialog livrDialog = new LivraisonDialog(x, y);
                livrDialog.Show();
            }
        }
    }
}
