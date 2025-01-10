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
using static Bitirme_projesi.Form3;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bitirme_projesi
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        MySqlConnection con = new MySqlConnection("Server=localhost;Database=bitirmeprojesi;Uid=root;Pwd=123456");
        private void YeniRestoranEkle(string restoranAdi)
        {
            Form6 yeniForm = new Form6();
            yeniForm.Text = restoranAdi;
            yeniForm.Show();
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO restoranlar (isim, adres, telefon, il,sahibinin_kullanıcı_adı) VALUES (@p1, @p2, @p3, @p4,@p5)", con);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            cmd.Parameters.AddWithValue("@p3", textBox3.Text);
            cmd.Parameters.AddWithValue("@p4", comboBox1.Text);
            cmd.Parameters.AddWithValue("@p5", GlobalData.kullanıcıadı);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("restoranınız eklenecektir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);






        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }
    }
}
