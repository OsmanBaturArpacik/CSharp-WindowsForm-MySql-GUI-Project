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
    public partial class editregister : Form
    {
        public editregister()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) => FormHelper.HandleFormClosing(this, sender, e);
        }

        private void editregister_Load(object sender, EventArgs e)
        {

        }
    }
}
