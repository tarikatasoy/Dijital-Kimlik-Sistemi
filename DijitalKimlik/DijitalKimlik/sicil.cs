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
    public partial class sicil : Form
    {
        public sicil()
        {
            InitializeComponent();
        }
        
        

        SqlConnection baglan = new SqlConnection("Data Source=WIN7\\SQLEXPRESS;Initial Catalog=kimlik;Integrated Security=True");

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }

    

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void sicil_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            baglan.Open();
            SqlCommand kontrol = new SqlCommand("Select * from SICIL where sicil_no='" + textBox1.Text + "' or sicil_icerik='"+textBox2.Text+"'  ", baglan);
            SqlDataReader read = kontrol.ExecuteReader();
            while (read.Read())
            {

                listBox1.Items.Add(read[0] + "  " + read[1]);
            }



            baglan.Close();
        }
    }
}
