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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        AnaSayfa ana = new AnaSayfa();
        Kayit ky = new Kayit();

        SqlConnection baglan = new SqlConnection("Data Source=WIN7\\SQLEXPRESS;Initial Catalog=kimlik;Integrated Security=True");

        private void Giris_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = (char)42;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM kullanici where Kuladi='" + textBox1.Text + "' AND Sifre='" + textBox2.Text + "'", baglan);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Hoş Geldiniz :" + textBox1.Text);
                    this.Hide();
                    ana.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Geçersiz Lütfen Tekrar Deneyiniz.");
                }
                baglan.Close();
            }
            else
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Admin where Adminkuladi='" + textBox1.Text + "' AND AdminSifre='" + textBox2.Text + "'", baglan);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Hoş Geldiniz :" + textBox1.Text);
                    this.Hide();
                    ky.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Geçersiz Lütfen Tekrar Deneyiniz.");
                }
                baglan.Close();
            }
        }
    }
}
