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
    public partial class Form4 : Form
    {
        private Dictionary<string, Form6> restoranFormlari = new Dictionary<string, Form6>();

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

     

        private void button1_Click(object sender, EventArgs e)
        {

            GlobalData.restoranadi = comboBox2.SelectedItem?.ToString();
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=bitirmeprojesi;Uid=root;Pwd=123456");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT sahibinin_kullanıcı_adı FROM restoranlar where isim =@p1 ", con);
            cmd.Parameters.AddWithValue("@p1", GlobalData.restoranadi);
            object result = cmd.ExecuteScalar();
            con.Close();
            GlobalData.sahibininkullanıcıadı = result.ToString();
            RestoranFormuAc(GlobalData.restoranadi);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GlobalData.GirisYapanForm = "Form4";
            Form8 form8 = new Form8("Form4");
            form8.Show();
            this.Hide();
        }
        public void RestoranFormuAc(string restoranAdi)
        {
            if (restoranFormlari.ContainsKey(restoranAdi))
            {
                Form6 form = restoranFormlari[restoranAdi];
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bu isimde bir restoran bulunamadı.");
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=bitirmeprojesi;Uid=root;Pwd=123456");
            con.Open();
            MySqlCommand cmd4 = new MySqlCommand("SELECT * FROM restoranlar", con);
            MySqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
                string restoranAdi = reader4["isim"].ToString();
                string restoranAdresi = reader4["adres"].ToString();

                Form6 yeniForm6 = new Form6
                {
                    Text = restoranAdi
                };

                // Restoran adını ve formunu sözlüğe ekle
                restoranFormlari[restoranAdi] = yeniForm6;
            }
            con.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=bitirmeprojesi;Uid=root;Pwd=123456");
            string secilensehir = comboBox1.SelectedItem?.ToString();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT il, isim FROM restoranlar where  il = @p1", con);
            cmd.Parameters.AddWithValue("@p1", secilensehir);
            MySqlDataReader reader = cmd.ExecuteReader();
            comboBox2.Items.Clear();
            while (reader.Read())
            {
                string restoranismi = reader["isim"].ToString();

                comboBox2.Items.Add(restoranismi);


            }
           
            con.Close();
        }
    }
}
