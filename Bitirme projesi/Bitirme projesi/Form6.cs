using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class Form6 : Form
    {
        decimal toplamFiyat = 0;
        decimal yemekFiyatı;
        decimal icecekFiyatı;
        decimal tatlıFiyati;
        decimal secilenurunlerinfiyati;
        decimal secilenurunlerinfiyati2;
        decimal secilenurunlerinfiyati3;
        public Form6()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=bitirmeprojesi;Uid=root;Pwd=123456");
        private void yorumyukle(){
            con.Open();
            MySqlCommand cmd4 = new MySqlCommand("select * from yorumlar where  hangirestorana = @p1", con);
            cmd4.Parameters.AddWithValue("@p1", GlobalData.restoranadi);
            MySqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
                string ad = reader4["İsim"].ToString();
                string yorum = reader4["yorum"].ToString();
                dataGridView1.Rows.Add(ad, yorum);
            }
            con.Close();
        }
    private void Form6_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Column1", "ad");
            dataGridView1.Columns.Add("Column2", "yorum");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            yorumyukle();

                if (GlobalData.kullanıcıadı == GlobalData.sahibininkullanıcıadı)
            {
                button3.Visible = true;

            }
            else
            {
                button3.Visible = false;


            }
            comboBox1.Items.Insert(0, "");
            comboBox2.Items.Insert(0, "");
            comboBox3.Items.Insert(0, "");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT yemekadi, yemekfiyati FROM yemeklistesi where hangirestoranda=@p1", con);
            cmd.Parameters.AddWithValue("@p1", GlobalData.restoranadi);
            MySqlDataReader reader = cmd.ExecuteReader();
            ;
            while (reader.Read())
            {
                string yemekAdı = reader["yemekadi"].ToString();
                yemekFiyatı = reader.GetDecimal("yemekfiyati");
                string yemekadıvefiyati = $"{yemekAdı} - {yemekFiyatı} TL";

                comboBox1.Items.Add(yemekadıvefiyati);

            }
            reader.Close();
            con.Close();
            con.Open();
            MySqlCommand cmd2 = new MySqlCommand("SELECT icecekadi, icecekfiyati FROM iceceklistesi where hangirestoranda=@p2", con);
            cmd2.Parameters.AddWithValue("@p2", GlobalData.restoranadi);
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                string icecekAdı = reader2["icecekadi"].ToString();
                icecekFiyatı = reader2.GetDecimal("icecekfiyati");
                string icecekadivefiyati = $"{icecekAdı} - {icecekFiyatı} TL";

                comboBox2.Items.Add(icecekadivefiyati);

            }


            reader2.Close();
            con.Close();
            con.Open();
            MySqlCommand cmd3 = new MySqlCommand("SELECT tatlıadi, fiyat FROM tatlılistesi where hangirestoranda=@p3", con);
            cmd3.Parameters.AddWithValue("@p3", GlobalData.restoranadi);
            MySqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                string tatlıAdı = reader3["tatlıadi"].ToString();
                tatlıFiyati = reader3.GetDecimal("fiyat");
                string tatliadivefiyati = $"{tatlıAdı} - {tatlıFiyati} TL";


                comboBox3.Items.Add(tatliadivefiyati);

            }
            reader3.Close();

            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 restoranForm = new Form7();
            restoranForm.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;

            string secilenUrun = comboBox1.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(secilenUrun))
            {
                listBox1.Items.Add(secilenUrun);
                secilenurunlerinfiyati = Convert.ToDecimal(secilenUrun.Split('-')[1].Replace(" TL", "").Trim());
                toplamFiyat += secilenurunlerinfiyati;
            }

            string secilenUrun2 = comboBox2.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(secilenUrun2))
            {
                listBox1.Items.Add(secilenUrun2);
                secilenurunlerinfiyati2 = Convert.ToDecimal(secilenUrun2.Split('-')[1].Replace(" TL", "").Trim());
                toplamFiyat += secilenurunlerinfiyati2;
            }

            string secilenUrun3 = comboBox3.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(secilenUrun3))
            {
                listBox1.Items.Add(secilenUrun3);
                secilenurunlerinfiyati3 = Convert.ToDecimal(secilenUrun3.Split('-')[1].Replace(" TL", "").Trim());
                toplamFiyat += secilenurunlerinfiyati3;
            }
            label5.Text = $"urunlerin toplam fiyati: {toplamFiyat}";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MessageBox.Show($"Siparisiniz Alınmıstır {toplamFiyat}");
            string siparisListesi = string.Join(", ", listBox1.Items.Cast<string>());
            listBox1.Items.Clear();
            label5.Text = $"urunlerin toplam fiyati {toplamFiyat}";
            MySqlCommand cmd = new MySqlCommand("INSERT INTO siparisler (kullanici_adi, siparisi_veren_adi,siparislistesi,siparisfiyati,siparis_hangi_restoranın, siparis_durumu) VALUES (@p1, @p2, @p3,@p4,@p6,@p5)", con);
            cmd.Parameters.AddWithValue("@p1", GlobalData.kullanıcıadı);
            cmd.Parameters.AddWithValue("@p2", GlobalData.ad);
            cmd.Parameters.AddWithValue("@p3", siparisListesi);
            cmd.Parameters.AddWithValue("@p4", toplamFiyat);
            cmd.Parameters.AddWithValue("@p5", "hazırlanıyor");
            cmd.Parameters.AddWithValue("@p6", GlobalData.restoranadi);
            toplamFiyat = 0;
            label5.Text = $"urunlerin toplam fiyati: {toplamFiyat}";
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           string silinenurun = (string)listBox1.SelectedItem;
           decimal silinecekurun = Convert.ToDecimal(silinenurun.Split('-')[1].Replace(" TL", "").Trim());
            listBox1.Items.Remove(listBox1.SelectedItem);
            toplamFiyat -= silinecekurun;
            label5.Text = $"urunlerin toplam fiyati: {toplamFiyat}";


        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string yorum = textBox1.Text;
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO yorumlar (isim,yorum,hangirestorana) VALUES (@p1, @p2, @p3)", con);
            cmd.Parameters.AddWithValue("@p1", GlobalData.ad);
            cmd.Parameters.AddWithValue("@p2", yorum);
            cmd.Parameters.AddWithValue("@p3", GlobalData.restoranadi);
            cmd.ExecuteNonQuery();
            con.Close();
            yorumyukle();
           


        }
    }
}
