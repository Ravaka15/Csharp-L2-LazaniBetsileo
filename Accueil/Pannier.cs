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
    public partial class Pannier : Form
    {

        public int total;
        public Pannier(string idCli,string nomCli)
        {
            InitializeComponent();
            txtIdCli.Text = idCli;
            txtNomCli.Text = nomCli;
        }
        public class prod {
            public static List<prod> listProd = new List<prod>();
            public string NomProd { get; set; }
            public int qttCom { get; set; }
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
            txtNomCli.Text = txtPrixtotal.Text = txtQttPannier.Text = string.Empty;
        }

        //bouton ajout Commande
        private void btnConfirmerAchat_Click(object sender, EventArgs e)
        {
            //creation variable
            int idCli = Convert.ToInt32(txtIdCli.Text.Trim());
            string refprod = txtrefprod.Text.Trim();
            string dateCom = dateCommande.Value.Date.ToString("yyyy-MM-dd");

            foreach (DataGridViewRow dr in dataGridViewPannier.Rows)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `commande`(`QttCom`, `DateCom`, `IdCli`, `Refprod`) VALUES (@qttCom,@dateCom,@idCli,@refprod)", db.getConnection);
                    MySqlCommand commande = new MySqlCommand("UPDATE `produit` SET `Qttprod`=(Qttprod-@qttAchat) WHERE Refprod=@refAchat", db.getConnection);
                    
                    //@idCOm,@qttCom,@dateCom,@idCli,@refCli
                    cmd.Parameters.AddWithValue("@qttCom",Convert.ToInt32(dr.Cells["Qtte"].Value));
                    cmd.Parameters.AddWithValue("@refprod", dr.Cells["refProd"].Value);
                    cmd.Parameters.Add("@dateCom", MySqlDbType.VarChar).Value = dateCom;
                    cmd.Parameters.Add("@idCli", MySqlDbType.VarChar).Value = idCli;

                    //@qttAchat,@refAchat
                    commande.Parameters.AddWithValue("@qttAchat", Convert.ToInt32(dr.Cells["Qtte"].Value));
                    commande.Parameters.AddWithValue("@refAchat", dr.Cells["refProd"].Value);
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
            txtQttPannier.Text = "";
            txtrefprod.Text = "";
            qttpro.Text = "";
            prixC.Text = "";
            dataGridViewPannier.Rows.Clear();
            prod.listProd.Clear();
        }

        //bouon exit
        private void pictureExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous quitter ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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

        //actualiser tableau produit
        public void actualiserProduit()
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE `produit` SET `Qttprod`=[] WHERE Refprod=?", db.getConnection);
        }
        // remplir le tableau du pannier
        public void actualiserTab()
        {
            dataGridViewPannier.Rows.Clear();
            foreach (var L in prod.listProd)
            {
                dataGridViewPannier.Rows.Add(L.NomProd, L.qttCom, L.prixCom,L.refprod);
            }
        }

        //bouton charger tableau achats
        private void pictureAdd_Click(object sender, EventArgs e)
        {
            if (txtrefprod.Text == "" || txtQttPannier.Text == "")
            {
                MessageBox.Show("Selectionner un produit", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string idC = txtIdCli.Text;
                string refprod = txtrefprod.Text;
                int prixP = Convert.ToInt32(prixC.Text);
                int qttP = int.Parse(txtQttPannier.Text);
                string nomP = txtNomprod.Text;
                int totalPrix = prixP * qttP;
                total += totalPrix;
                txtPrixtotal.Text = string.Format("{0}",total);
               if (qttP <= Convert.ToInt32(qttpro.Text))
               { 
                   prod.listProd.Add(new prod
                    {
                        NomProd = nomP,
                        qttCom = qttP,
                        prixCom = totalPrix,
                        refprod = refprod
                    });
                   
               }
               else
               {
                    MessageBox.Show("Il y a seulement " + qttpro.Text.Trim() +"  "+txtNomprod.Text+"  veuillez- choisi a nouveau", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               actualiserTab();

               //vider champs
               txtNomprod.Text = "";
               txtQttPannier.Text = "";
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

        private void txtPrixtotal_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
