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

namespace Bitirme_projesi
{
    public partial class Form8 : Form
    {
        private string fromForm;
        public Form8(string fromForm)
        {

            InitializeComponent();
            this.fromForm = fromForm;
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=bitirmeprojesi;Uid=root;Pwd=123456");
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (fromForm == "Form7")
            {
                label1.Visible = true;
                label2.Visible = true;
                button1.Visible = true;
                comboBox1.Visible = true;
                textBox1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                button1.Visible = false;
                comboBox1.Visible = false;
                textBox1.Visible = false;
            }
            dataGridView1.Columns.Add("Column1", "siparis_id");
            dataGridView1.Columns.Add("Column2", "durum");
            dataGridView1.Columns.Add("Column3", "ad");
            dataGridView1.Columns.Add("Column4", "siparislistesi");
            dataGridView1.Columns.Add("Column5", "siparisfiyati");
            Veriyukle();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int siparisid = Convert.ToInt32(textBox1.Text);
                string siparisdurumu = comboBox1.Text;
                con.Open();
                MySqlCommand cmd = new MySqlCommand("update siparisler set siparis_durumu=@p2 where siparis_id=@p1 ", con);
                cmd.Parameters.AddWithValue("@p1", siparisid);
                cmd.Parameters.AddWithValue("@p2", siparisdurumu);
                dataGridView1.Rows.Clear();
                int sayi = cmd.ExecuteNonQuery();
                con.Close();
                Veriyukle();
                if (sayi > 0)
                {
                    MessageBox.Show("islem basarıyla yapıldı");
                }

                else
                {
                    MessageBox.Show("oyle bir siparis yok");
                }
            }



            catch (Exception ex)
            {

                con.Close();
                MessageBox.Show("islem yapılamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Veriyukle()
        {
            con.Open();
            if (GlobalData.GirisYapanForm == "Form4")
            {
                MySqlCommand cmd = new MySqlCommand("select * from siparisler where  kullanici_adi = @p1", con);
                cmd.Parameters.AddWithValue("@p1", GlobalData.kullanıcıadı);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                { 
                    string siparisid = reader["siparis_id"].ToString();
                    string durum = reader["siparis_durumu"].ToString();
                    string ad = reader["siparisi_veren_adi"].ToString();
                    string siparislistesi = reader["siparislistesi"].ToString();
                    string siparisfiyati = reader["siparisfiyati"].ToString();
                    dataGridView1.Rows.Add(siparisid, durum, ad, siparislistesi, siparisfiyati);
                }
            }
            else
            {
                MySqlCommand cmd2 = new MySqlCommand("select * from siparisler where siparis_hangi_restoranın = @p2", con);
                cmd2.Parameters.AddWithValue("@p2", GlobalData.restoranadi);
                MySqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    string siparisid = reader["siparis_id"].ToString();
                    string durum = reader["siparis_durumu"].ToString();
                    string ad = reader["siparisi_veren_adi"].ToString();
                    string siparislistesi = reader["siparislistesi"].ToString();
                    string siparisfiyati = reader["siparisfiyati"].ToString();
                    dataGridView1.Rows.Add(siparisid, durum, ad, siparislistesi, siparisfiyati);
                }
              
            }
            con.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
            this.Hide();
        }
    }
}
