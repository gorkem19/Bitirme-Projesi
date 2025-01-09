using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bitirme_projesi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=bitirmeprojesi;Uid=root;Pwd=123456");
        public static class GlobalData
        {
            // Global değişken, her yerden erişilebilir
            public static string kullanıcıadı;
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalData.kullanıcıadı = textBox1.Text;


            con.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from uyebilgileri where kullanıcıadı=@p1 and sifre=@p2", con);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            MySqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
                {


                    con.Close();
                    Form4 anaForm = new Form4();
                    anaForm.Show();
                    this.Hide();

                }
            else
            {
                MessageBox.Show("hatalı giris");
                con.Close();
            }


        }

            private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }
    }
}
