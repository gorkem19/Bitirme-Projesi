using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bitirme_projesi.Form3;

namespace Bitirme_projesi
{
    public partial class Form4 : Form
    {


        public Form4()
        {
            InitializeComponent();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 restoranForm = new Form5();
            restoranForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (GlobalData.kullanıcıadı == "g")
            {
                Form6 restoranForm = new Form6();

                restoranForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("restoranın yok");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 restoranForm = new Form6();
            restoranForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.Show();
            this.Hide();
        }
    }
}
