using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cevhermobilya.Properties
{
    internal class FormHelper
    {
        public static void HandleFormClosing(Form form, object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamayı kapatmak istediğinizden emin misiniz?", "Kapat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                e.Cancel = true;
                form.Activate();
            }
        }

    }
}
