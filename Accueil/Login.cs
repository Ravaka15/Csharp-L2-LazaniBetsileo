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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous quitter ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            Index d = new Index();
            this.Hide();
            d.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
