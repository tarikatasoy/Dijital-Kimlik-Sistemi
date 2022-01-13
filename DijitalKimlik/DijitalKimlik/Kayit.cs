using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DijitalKimlik
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=WIN7\\SQLEXPRESS;Initial Catalog=kimlik;Integrated Security=True");
        

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            textBox7.Text = textBox1.Text;
            textBox7.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty ||
                   textBox5.Text == string.Empty || textBox6.Text == string.Empty||textBox10.Text == string.Empty|| textBox11.Text == string.Empty)
            {
                MessageBox.Show("Bilgileri Eksiksiz Şekilde Doldurduğunuza Emin Olun ve Tekrar Deneyiniz.");

            }
            else
            {

                SqlCommand kontrol = new SqlCommand("Select count(*) from kimlik where TC='" + textBox1.Text + "'", baglan);
                SqlCommand kontrol2 = new SqlCommand("Select count(*) from SICIL where sicil_no='" + textBox10.Text + "'", baglan);
             
                
                baglan.Open();
                int sonuc2 = (int)kontrol2.ExecuteScalar();
                int sonuc = (int)kontrol.ExecuteScalar();
                baglan.Close();
                
                if (sonuc == 0)
                {
                    baglan.Open();
                    SqlCommand ekle = new SqlCommand("insert into kimlik(TC, Ad, Soyad, DogumTarihi, DogumYeri, Ulke) values (@tc,@ad,@soyad,@dg,@dy,@ulke)", baglan);
                    ekle.Parameters.AddWithValue("@tc", textBox1.Text);
                    ekle.Parameters.AddWithValue("@ad", textBox2.Text);
                    ekle.Parameters.AddWithValue("@soyad", textBox3.Text);
                    ekle.Parameters.AddWithValue("@dg", textBox4.Text);
                    ekle.Parameters.AddWithValue("@dy", textBox5.Text);
                    ekle.Parameters.AddWithValue("@ulke", textBox6.Text);
                    ekle.ExecuteNonQuery();



                    if (sonuc2 == 0)
                    {

                        SqlCommand ekle2 = new SqlCommand("insert into SICIL (sicil_no, sicil_icerik, TC) values (@sno,@sic,@tc )", baglan);
                        ekle2.Parameters.AddWithValue("@tc", textBox1.Text);
                        ekle2.Parameters.AddWithValue("@sno", textBox10.Text);
                        ekle2.Parameters.AddWithValue("@sic", textBox11.Text);
                        ekle2.ExecuteNonQuery();
                        baglan.Close();

                        MessageBox.Show("Kaydınız Eklendi");
                        this.Hide();
                        Giris gir = new Giris();
                        gir.Show();
                    }
                    else { label9.Text = "Kayıt Başarısız. sicil no zaten sistemde kayıtlı başka bir sicil no ile kayıt yapabilirsiniz."; }
                }

                else { label9.Text = "Kayıt Başarısız. TC zaten sistemde kayıtlı başka bir TC ile kayıt yapabilirsiniz."; }


            }
        
        }
    }
}
