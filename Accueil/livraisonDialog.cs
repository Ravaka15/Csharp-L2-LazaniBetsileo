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
    public partial class LivraisonDialog : Form
    {


        public LivraisonDialog(string x, string y)
        {
            InitializeComponent();
            txtIdFou.Text = x;
            txtNomFournisseur.Text = y;
        }
        public class prod {
            public static List<prod> listProd = new List<prod>();
            public string NomProd { get; set; }
            public int qttLiv { get; set; }
            public int prixCom { get; set; }
            public string refprod { get; set; }
        }
        //Importer classe mere database
        Mydatabase db = new Mydatabase();

        //Importer classe fournisseur
        PannierDAO client = new PannierDAO();

        DataTable table = new DataTable();

        private void Pannier_Load(object sender, EventArgs e)
        {
            //Importer la fonction l'affichage de tableau Produit
            chargertableauPro();
        }

        //Creation de la fonction d'affichage Produit
        private void chargertableauPro()
        {
            dataGridViewProduit.DataSource = getProduits();
        }

        private object getProduits()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT Nomprod,Qttprod,Prixprod,Refprod FROM `produit`", db.getConnection);

            db.openConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return table;
        }

        //Vider les champs
        public void Clear()
        {
            txtNomFournisseur.Text= txtQttLivrer.Text = string.Empty;
        }

        //bouton ajout Commande
        private void btnConfirmerAchat_Click(object sender, EventArgs e)
        {
            //creation variable
            int idFrs = Convert.ToInt32(txtIdFou.Text.Trim());
            string refprod = txtrefprod.Text.Trim();
            string dateLiv = dateLivre.Value.Date.ToString("yyyy-MM-dd");

            foreach (DataGridViewRow dr in dataGridViewLivre.Rows)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `livrer`(`QttLiv`, `DateLiv`, `IdFrs`, `Refprod`) VALUES (@qttLiv,@dateLiv,@idFrs,@refprod)", db.getConnection);
                    MySqlCommand commande = new MySqlCommand("UPDATE `produit` SET `Qttprod`=(Qttprod+@qttLivraison) WHERE Refprod=@refLivraison", db.getConnection);
                    
                    //@qttLiv,@dateLiv,@idFrs,@refprod
                    cmd.Parameters.AddWithValue("@qttLiv",Convert.ToInt32(dr.Cells["Qtte"].Value));
                    cmd.Parameters.AddWithValue("@refprod", dr.Cells["refProd"].Value);
                    cmd.Parameters.Add("@dateLiv", MySqlDbType.VarChar).Value = dateLiv;
                    cmd.Parameters.Add("@idFrs", MySqlDbType.VarChar).Value = idFrs;

                    //@qttLivraison,@refLivraison
                    commande.Parameters.AddWithValue("@qttLivraison", Convert.ToInt32(dr.Cells["Qtte"].Value));
                    commande.Parameters.AddWithValue("@refLivraison", dr.Cells["RefProd"].Value);
                    db.openConnection();
                    if (cmd.ExecuteNonQuery() == 1 && commande.ExecuteNonQuery() == 1)
                    {
                        db.closeConnection();
                    }
                    else
                    {
                        db.closeConnection();
                    }
                }
                catch (MySqlException ex) {
                    MessageBox.Show("error"+ex);
                }
            } 
            if (MessageBox.Show("Voulez vous confirmer ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();

        }

        //bouton annuler
        private void btnAnnulerAchat_Click(object sender, EventArgs e)
        {
            //vider champs
            txtNomprod.Text = "";
            txtQttLivrer.Text = "";
            txtrefprod.Text = "";
            qttpro.Text = "";
            prixC.Text = "";
            dataGridViewLivre.Rows.Clear();
            prod.listProd.Clear();
        }

        //bouon exit
        private void pictureExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous quitter ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        //Click produit
        private void dataGridViewProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             DataGridView selGrid = (DataGridView)sender;
            try
            {
                if (dataGridViewProduit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txtrefprod.Text = (dataGridViewProduit.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txtNomprod.Text = (dataGridViewProduit.Rows[e.RowIndex].Cells[0].Value.ToString());
                    prixC.Text = (dataGridViewProduit.Rows[e.RowIndex].Cells[2].Value.ToString());
                    qttpro.Text = (dataGridViewProduit.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("table vide ou " + ex);
            }
        }

        // remplir le tableau du pannier
        public void actualiserTab()
        {
            dataGridViewLivre.Rows.Clear();
            foreach (var L in prod.listProd)
            {
                dataGridViewLivre.Rows.Add(L.NomProd, L.qttLiv, L.prixCom,L.refprod);
            }
        }

        //bouton charger tableau achats
        private void pictureAdd_Click(object sender, EventArgs e)
        {
            if (txtrefprod.Text == "" || txtQttLivrer.Text == "")
            {
                MessageBox.Show("Selectionner un produit", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string idC = txtIdFou.Text;
                string refprod = txtrefprod.Text;
                int prixP = Convert.ToInt32(prixC.Text);
                int qttP = int.Parse(txtQttLivrer.Text);
                string nomP = txtNomprod.Text;
                int totalPrix = prixP * qttP;
                prod.listProd.Add(new prod
                     {
                         NomProd = nomP,qttLiv = qttP,prixCom = totalPrix,refprod = refprod
                     });

               actualiserTab();

               //vider champs
               txtNomprod.Text = "";
               txtQttLivrer.Text = "";
               txtrefprod.Text = "";
               qttpro.Text = "";
               prixC.Text = "";
            }
        }

        //numerique seulement entrena
        private void txtQttPannier_KeyPress(object sender, KeyPressEventArgs e)
        {
            //text numerique
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
