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

namespace  Accueil
{
    public partial class Produit : Form
    {
        public Produit()
        {
            InitializeComponent();
        }

        //Importer la classe mere
        Mydatabase db = new Mydatabase();

        //Importer classe fournisseur
        ProduitDAO produit = new ProduitDAO();

        private void Produit_Load(object sender, EventArgs e)
        {
            //Importer la fonction d"affichage produit
            chargertableauPro();
        }

        //Creation de la fonction d'affichage Produit
        private void chargertableauPro()
        {
            dataGridViewProduit.DataSource = getProduits();
        }
     
        private object getProduits()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT* FROM `produit`", db.getConnection);

            db.openConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return table;
        }

        //btn ajout produit
        private void btnAjoutProduit_Click(object sender, EventArgs e)
        {
            //creation variable
            string nomprod = txtNomprod.Text.Trim();
            string type = comboBoxTypeprod.Text.Trim();
            int prixprod = Convert.ToInt32(txtPrixprod.Text.Trim());
            int qttprod = Convert.ToInt32(txtQttprod.Text.Trim());

            if (produit.AjoutProduit(nomprod,type,prixprod,qttprod))
            {
                MessageBox.Show("Produit enregistrer avec succes", "Ajouter produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur d'ajout produit", "Ajouter produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //boutm modifier produit
        private void btnModifierProduit_Click(object sender, EventArgs e)
        {
            //creation variable
            string nomprod = txtNomprod.Text.Trim();
            string type = comboBoxTypeprod.Text.Trim();
            int prixprod = Convert.ToInt32(txtPrixprod.Text.Trim());
            int qttprod = Convert.ToInt32(txtQttprod.Text.Trim());
            int refprod = Convert.ToInt32(txtRefprod.Text.Trim());

            if (produit.ModifierProduit(refprod,nomprod, type, prixprod, qttprod))
            {
                MessageBox.Show("Produit modifier avec succes", "Ajouter produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur de modification produit", "Ajouter produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //btn supprimer
        private void btnSupprimerProduit_Click(object sender, EventArgs e)
        {
            //creation variable
            int refprod = Convert.ToInt32(txtRefprod.Text.Trim());

            if (produit.SupprimerProduit(refprod))
            {
                MessageBox.Show("Client supprime avec succes", "Supprimer produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
  

        //Click table produit
        private void dataGridViewProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView selGrid = (DataGridView)sender;
            try
            {
                if (dataGridViewProduit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txtRefprod.Text = (dataGridViewProduit.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtNomprod.Text = (dataGridViewProduit.Rows[e.RowIndex].Cells[1].Value.ToString());
                    comboBoxTypeprod.Text = (dataGridViewProduit.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtPrixprod.Text = (dataGridViewProduit.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txtQttprod.Text = (dataGridViewProduit.Rows[e.RowIndex].Cells[4].Value.ToString());
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("table vide ou " + ex);
            }
        }

        //importer la fonction recherche produit
        private void txtChercheProduit_TextChanged(object sender, EventArgs e)
        {
            rechercheProduits(txtChercheProduit.Text.Trim());
        }

        //recherch produits
        private void rechercheProduits(string produit)
        {
            DataTable table = new DataTable();

            MySqlCommand cmd = new MySqlCommand("SELECT `Refprod`, `Nomprod`, `Typeprod`, `Prixprod`, `Qttprod` FROM `produit` WHERE CONCAT(produit.Refprod,produit.Nomprod,produit.Typeprod,produit.Prixprod,produit.Qttprod) LIKE '%" + produit + "%'", db.getConnection);
            db.openConnection();

            MySqlDataReader reader = cmd.ExecuteReader();

            table.Load(reader);

            dataGridViewProduit.DataSource = table;
        }

        //numerque seulemnt
        private void txtPrixprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            //text numerique
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //numerique seulement
        private void txtQttprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            //text numerique
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

    }


}
