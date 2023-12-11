using cevhermobilya.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cevhermobilya
{
    public partial class createregister : Form
    {
        public createregister()
        {
            InitializeComponent();

            this.FormClosing += (sender, e) => FormHelper.HandleFormClosing(this, sender, e);
        }



        private void newordercreate_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void input_name_TextChanged(object sender, EventArgs e)
        {
            InputValidator.AllowAllCharacters(input_name);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        int pno = 1;
        private void button2_Click(object sender, EventArgs e)//add product data grid
        {            
            if(input_productcode.Text == "" || input_numberofproduct.Text == "" || input_color.Text == "") //description can be null and extra can be null
            {
                MessageBox.Show("Lütfen Tüm alanları doldurunuz.(Açıklama ve ekstra kısmı boş bırakılabilir.)", ("Eksik Bilgi Girişi Tespit Edildi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (MySqlConnection connection = ConnectionMySql.GetConnection())
            {
                connection.Open();
                string searchvalue = input_productcode.Text;
                string query = "SELECT * FROM productprice WHERE productcode = @searchvalue";
                try
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchvalue ", searchvalue);

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            float productprice = reader.GetFloat("productprice");
                            float extraprice = float.Parse(extra_addtototalpayment.Text);
                            int numberofproduct = int.Parse(input_numberofproduct.Text);
                            float totalpayment = 0;
                            if (!(string.IsNullOrEmpty(extra_addtototalpayment.Text)))
                            {
                                totalpayment = numberofproduct * (extraprice + productprice);
                            }
                            else
                            {
                                totalpayment = numberofproduct * productprice;
                            }
                            dataGridViewPRODUCTS.Rows.Add(pno, input_productcode.Text, input_productdescription.Text, input_numberofproduct.Text, input_color.Text, productprice, totalpayment);
                            MessageBox.Show("Ürün başarıyla tabloya eklendi.", ("İşlem Başarıyla Tamamlandı"), MessageBoxButtons.OK, MessageBoxIcon.None);
                            pno += 1;
                            input_productcode.Clear();
                            input_numberofproduct.Clear();
                            input_color.Clear();
                            input_productdescription.Clear();
                            extra_addtototalpayment.Clear();
                        }

                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz kodda ürün bulunamadı. Lütfen geçerli kod giriniz.", ("Hatalı Ürün Kodu"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        input_productcode.Clear();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    input_productcode.Clear();
                    input_numberofproduct.Clear();
                    input_color.Clear();
                    input_productdescription.Clear();
                    extra_addtototalpayment.Clear();
                }
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            input_companyname
            input_name
            input_surname
            input_citizenshipnumber
            input_phone1
            input_phone2//null
            input_deliveryaddress
            input_orderdate //?
            input_shipdate/null
            input_branch
            en az bir ürün için datagridview kontrol edilecek.
            */
            if (input_companyname.Text == "" || input_name.Text == "" || input_surname.Text == "" || input_citizenshipnumber.Text == "" || input_phone1.Text == "" || input_deliveryaddress.Text == "" || input_branch.Text == "") //phone2, shipdate can be null
            {
                MessageBox.Show("Lütfen Tüm alanları doldurunuz.(GSM ve Sevk Tarihi boş bırakılabilir.)", ("Eksik Bilgi Girişi Tespit Edildi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataGridViewPRODUCTS.Rows.Count == 0 || (dataGridViewPRODUCTS.Rows.Count == 1 && dataGridViewPRODUCTS.Rows[0].IsNewRow))
            {
                MessageBox.Show("Kayıdı oluşturmak için en az 1 adet ürün eklemeniz gerekmektedir.", ("Sepette Ürün Bulunamadı!"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Kayiti oluşturmak istediğinzden emin misiniz?", "Kaydet ve Devam et", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("verileri database kaydet ve kaydi olustur.", "Bilgi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                //verileri database kaydet ve kaydi olustur
                //if(her sey tamamsa pencereyi kapat)
                this.Close();

                using (MySqlConnection connection = ConnectionMySql.GetConnection())
                {
                    //kdv %10
                    string queryInfo = "INSERT INTO orderforminfo ( companyname, name, surname, citizenshipnumber, phone1, phone2, deliveryaddress, orderdate, shipdate, branch, totalsum, paymentplan ) " +
                          "VALUES ( @Companyname, @Name, @Surname, @CitizenshipNumber, @Phone1, @Phone2, @DeliveryAddress, @OrderDate, @ShipDate, @Branch, @TotalSum, @PaymentPlan )";

                    MySqlCommand commandInfo = new MySqlCommand(queryInfo, connection);

                    //command2.Parameters.AddWithValue("@OrderNo", 1234); // auto increment
                    commandInfo.Parameters.AddWithValue("@CompanyName", input_companyname.Text);
                    commandInfo.Parameters.AddWithValue("@Name ", input_name.Text);
                    commandInfo.Parameters.AddWithValue("@Surname", input_surname.Text);
                    commandInfo.Parameters.AddWithValue("@CitizenshipNumber", input_citizenshipnumber.Text);
                    commandInfo.Parameters.AddWithValue("@Phone1", input_phone1.Text);
                    commandInfo.Parameters.AddWithValue("@Phone2", input_phone2.Text);
                    commandInfo.Parameters.AddWithValue("@DeliveryAddress", input_deliveryaddress.Text);
                    commandInfo.Parameters.AddWithValue("@OrderDate", input_orderdate.Text);
                    commandInfo.Parameters.AddWithValue("@ShipDate", input_orderdate.Text);
                    commandInfo.Parameters.AddWithValue("@Branch", input_branch.Text);
                    commandInfo.Parameters.AddWithValue("@TotalSum", 1234);
                    commandInfo.Parameters.AddWithValue("@PaymentPlan", input_paymentplan.Text);



                    //****************************************************************
                    string queryProduct = "INSERT INTO orderformproducts ( orderno, productcode, numberofproduct, color, productdescription, productprice, productextraprice) " +
                          "VALUES (@OrderNo, @ProductCode, @NumberOfProduct, @Color, @ProductDescription, @ProductPrice, @ProductExtraPrice)";

                    MySqlCommand commandProduct = new MySqlCommand(queryProduct, connection);


                    for (int i = 0; i < dataGridViewPRODUCTS.Rows.Count; i++)
                    {

                        DataGridViewRow row = dataGridViewPRODUCTS.Rows[i];

                        commandProduct.Parameters.AddWithValue("@OrderNo", row.Cells["productcode"].Value.ToString());
                        commandProduct.Parameters.AddWithValue("@ProductCode", row.Cells["productdescription"].Value.ToString());
                        commandProduct.Parameters.AddWithValue("@NumberOfProduct", Convert.ToInt32(row.Cells["numberofproduct"].Value));
                        commandProduct.Parameters.AddWithValue("@Color", row.Cells["productcolor"].Value.ToString());
                        commandProduct.Parameters.AddWithValue("@ProductDescription", Convert.ToDouble(row.Cells["productprice"].Value));
                        commandProduct.Parameters.AddWithValue("@ProductPrice", Convert.ToDouble(row.Cells["extras"].Value));
                        commandProduct.Parameters.AddWithValue("@ProductExtraPrice", Convert.ToDouble(row.Cells["productsum"].Value));

                    }

                    connection.Open();
                    try
                    {
                        commandProduct.ExecuteNonQuery();
                        commandInfo.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    connection.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void input_companyname_TextChanged(object sender, EventArgs e)
        {
            InputValidator.AllowAllCharacters(input_companyname);
        }

        private void input_productcode_TextChanged(object sender, EventArgs e)
        {
            InputValidator.AllowAllCharacters(input_productcode);
        }

        private void input_numberofproduct_TextChanged(object sender, EventArgs e)
        {
            InputValidator.AllowOnlyDigits(input_numberofproduct);
        }

        private void input_color_TextChanged(object sender, EventArgs e)
        {
            InputValidator.AllowAllCharacters(input_color);
        }

        private void input_productdescription_TextChanged(object sender, EventArgs e)
        {
            InputValidator.AllowAllCharacters(input_productdescription);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kayiti iptal etmek istediğinizden emin misiniz?\nBu işlem geri dönüşü olmayan bir işlemdir.","Kayit İptal Edilsin Mi?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void input_phone1_TextChanged(object sender, EventArgs e)
        {
            InputValidator.AllowOnlyDigits(input_phone1);
        }

        private void input_phone2_TextChanged(object sender, EventArgs e)
        {
            InputValidator.AllowOnlyDigits(input_phone2);
        }

        private void input_citizenshipnumber_TextChanged(object sender, EventArgs e)
        {
            InputValidator.AllowOnlyDigits(input_citizenshipnumber);
        }

        private void input_surname_TextChanged(object sender, EventArgs e)
        {
            InputValidator.AllowAllCharacters(input_surname);
        }       

        private void input_deliveryaddress_TextChanged(object sender, EventArgs e)
        {
            InputValidator.AllowAllCharacters(input_deliveryaddress);
        }

        private void input_branch_TextChanged(object sender, EventArgs e)
        {
            InputValidator.AllowAllCharacters(input_branch);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void extra_addtototalpayment_TextChanged(object sender, EventArgs e)
        {
            InputValidator.AllowOnlyDigits(extra_addtototalpayment);
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
