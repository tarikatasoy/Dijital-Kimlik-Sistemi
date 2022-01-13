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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        kimlikb k = new kimlikb();
        pasaport pa = new pasaport();
        sicil scl = new sicil();
        saglik sg = new saglik();
        egitim eg = new egitim();
        private void index_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            k.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            pa.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            scl.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            sg.Show();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            eg.Show();
        }

       

      
    }
}
