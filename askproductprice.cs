using cevhermobilya.Properties;
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

namespace cevhermobilya
{
    public partial class askproductprice : Form
    {
        public askproductprice()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) => FormHelper.HandleFormClosing(this, sender, e);
        }

        private void ask_product_Click(object sender, EventArgs e)
        {
            //text boxtaki kelimeyi databasede arat varsa data grid kımsına fiyati ve kodu yaz eger oyle bir sey yoksa hata mesaji ver
            using (MySqlConnection connection = ConnectionMySql.GetConnection())
            {
                // TextBox'tan ürün kodunu al
                string productCode = ask_productcode.Text;

                // Veritabanında sorgulama yapmak için SQL sorgusu
                // REGEXP misal kod e-132 fakat kullanici e-132x girdi esas e-132 alinir
                string query = "SELECT productcode, productprice FROM productprices WHERE productcode REGEXP @ProductCode = @ProductCode";

                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@ProductCode", ask_productcode.Text);

                connection.Open();
                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Veritabanında kayıt bulundu, DataGridView'e ekle
                            dataGridView1.Rows.Add(reader["productcode"].ToString(), reader["productprice"].ToString());
                        }
                        else
                        {
                            // Veritabanında kayıt bulunamadı
                            MessageBox.Show("Ürün bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            ask_productcode.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ana menüye dönmek istediğinizden emin misiniz?","Ana Menüye Dön", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }
         // test connection sql
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = ConnectionMySql.GetConnection())
                {
                    connection.Open();
                    MessageBox.Show("MySQL bağlantısı başarılı bir şekilde kuruldu.");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL bağlantısı kurulurken bir hata oluştu: " + ex.Message);
            }
        }
        // test connection sql

        private void button1_Click(object sender, EventArgs e)
        {
            btnTestConnection_Click(sender, e);
        }

        private void ask_productcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void askproductprice_Load(object sender, EventArgs e)
        {

        }
    }
}
