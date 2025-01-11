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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=bitirmeprojesi;Uid=root;Pwd=123456");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO yemeklistesi (yemekadı, yemekfiyati, sahibininkullanıcıadı) VALUES (@p1, @p2, @p3)", con);
                cmd.Parameters.AddWithValue("@p1", textBox1.Text);
                cmd.Parameters.AddWithValue("@p2", Convert.ToInt32(textBox4.Text));
                cmd.Parameters.AddWithValue("@p3", GlobalData.kullanıcıadı);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Yemek eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("hatalı deger girisi yaptınız yemek icecek tatlı adı sadece harflerden olusmalı yemek icecek tatlı fiyati ise sadece sayıdan olusmalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO iceceklistesi (icecekadı,icecekfiyati,sahibininkullanıcıadı) VALUES (@p1, @p2,@p3)", con);
                cmd.Parameters.AddWithValue("@p1", textBox2.Text);
                cmd.Parameters.AddWithValue("@p2", Convert.ToInt32(textBox5.Text));
                cmd.Parameters.AddWithValue("@p3", GlobalData.kullanıcıadı);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("icecek eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("hatalı deger girisi yaptınız yemek icecek tatlı adı sadece harflerden olusmalı yemek icecek tatlı fiyati ise sadece sayıdan olusmalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tatlılistesi (tatlıadı,fiyat,sahibininkullanıcıadı) VALUES (@p1, @p2, @p3)", con);
                cmd.Parameters.AddWithValue("@p1", textBox3.Text);
                cmd.Parameters.AddWithValue("@p2", Convert.ToInt32(textBox6.Text));
                cmd.Parameters.AddWithValue("@p3", GlobalData.kullanıcıadı);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("tatlı eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("hatalı deger girisi yaptınız yemek icecek tatlı adı sadece harflerden olusmalı yemek icecek tatlı fiyati ise sadece sayıdan olusmalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();


                MySqlCommand cmd = new MySqlCommand("DELETE FROM yemeklistesi WHERE yemekadı=@p1", con);
                cmd.Parameters.AddWithValue("@p1", textBox7.Text);


                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0)
                {

                    MessageBox.Show("Yemek silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Öyle bir yemek, içecek, tatlı yok", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();

                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();


                MySqlCommand cmd = new MySqlCommand("DELETE FROM iceceklistesi WHERE icecekadı=@p1", con);
                cmd.Parameters.AddWithValue("@p1", textBox8.Text);


                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0)
                {

                    MessageBox.Show("icecek silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Öyle bir yemek, içecek, tatlı yok", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();

                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();


                MySqlCommand cmd = new MySqlCommand("DELETE FROM tatlılistesi WHERE tatlıadı=@p1", con);
                cmd.Parameters.AddWithValue("@p1", textBox9.Text);


                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0)
                {

                    MessageBox.Show("tatlı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Öyle bir yemek, içecek, tatlı yok", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();

                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8("Form7"); 
            form8.Show();
            this.Hide();
        }
    }
}
