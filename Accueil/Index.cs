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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            loadform(new Dashboard()); //maneho dash voaloany
        }
        public void loadform(Object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void pictureExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous quitter ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            loadform(new Dashboard());
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            loadform(new Produit());
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            loadform(new Client());
        }

        private void btnAchat_Click(object sender, EventArgs e)
        {
            loadform(new Achats());
        }

        private void btnFournisseur_Click(object sender, EventArgs e)
        {
            loadform(new Fournisseur());
        }

        private void btnLivraison_Click(object sender, EventArgs e)
        {
            loadform(new Livraison());
        }

        private void btnFacture_Click(object sender, EventArgs e)
        {
            loadform(new Facture());
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous changer le compte ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ;
            Login log = new Login();
            this.Hide();
            log.Show();
            
        }



        
    }
}
