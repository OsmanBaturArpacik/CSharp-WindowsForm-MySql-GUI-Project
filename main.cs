using cevhermobilya.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cevhermobilya
{
    public partial class mainui : Form
    {
        public mainui()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) => FormHelper.HandleFormClosing(this, sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
     
        }

        private void main_Load(object sender, EventArgs e)
        {

        }


        private void createregister_Click(object sender, EventArgs e)
        {
            createregister createregister = new createregister();
            createregister.FormClosed += (s, args) => this.Show(); 
            createregister.Show();

            this.Hide();
        }
        private void editregister_Click(object sender, EventArgs e)
        {
            editregister editregister = new editregister();
            editregister.FormClosed += (s, args) => this.Show();
            editregister.Show();

            this.Hide();
        }
        private void askregister_Click(object sender, EventArgs e)
        {
            askregister askregister = new askregister();
            askregister.FormClosed += (s, args) => this.Show();
            askregister.Show();

            this.Hide();
        }
        private void askproductprice_Click(object sender, EventArgs e)
        {
            askproductprice askproductprice = new askproductprice();
            askproductprice.FormClosed += (s, args) => this.Show();
            askproductprice.Show();

            this.Hide();

        }
        private void productaddremovechange_Click(object sender, EventArgs e)
        {
            productaddremovechange productaddremovechange = new productaddremovechange();
            productaddremovechange.FormClosed += (s, args) => this.Show();
            productaddremovechange.Show();

            this.Hide();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
