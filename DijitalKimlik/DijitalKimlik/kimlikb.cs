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
    public partial class kimlikb : Form
    {
        public kimlikb()
        {
            InitializeComponent();
        }
        pasaport pa = new pasaport();
        sicil scl = new sicil();
        saglik sg = new saglik();
        egitim eg = new egitim();
        SqlConnection baglan = new SqlConnection("Data Source=WIN7\\SQLEXPRESS;Initial Catalog=kimlik;Integrated Security=True");
        private void kimlik_Load(object sender, EventArgs e)
        {

        }

       

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            eg.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            scl.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            pa.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            sg.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            baglan.Open();
            SqlCommand kontrol = new SqlCommand("Select * from kimlik where TC='" + textBox1.Text + "'", baglan);
            SqlDataReader read = kontrol.ExecuteReader();
            while (read.Read()) {

                listBox1.Items.Add(read[0] + "  " + read[1] + "  " + read[2] + "  " + read[3] + "  " + read[4] + "  " + read[5]);
            }
            
          

            baglan.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
