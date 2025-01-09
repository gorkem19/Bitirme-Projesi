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
using Mysqlx.Crud;
using Org.BouncyCastle.Crypto.Macs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bitirme_projesi
{
    public partial class Form2 : Form

    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=bitirmeprojesi;Uid=root;Pwd=123456");





        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();



            MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM uyebilgileri WHERE kullanıcıadı = @p1", con);
            checkCmd.Parameters.AddWithValue("@p1", textBox1.Text);


            int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (userCount > 0)
            {

                MessageBox.Show("Bu kullanıcı adı zaten alınmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("insert into uyebilgileri  values(@p1,@p2,@p3,@p4)", con);
                cmd.Parameters.AddWithValue("@p1", textBox1.Text);
                cmd.Parameters.AddWithValue("@p2", textBox2.Text);
                cmd.Parameters.AddWithValue("@p3", textBox3.Text);
                cmd.Parameters.AddWithValue("@p4", textBox4.Text);
                con.Close();
                cmd.ExecuteNonQuery();


                MessageBox.Show("uye oldunuz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }


        private void Form2_Load(object sender, EventArgs e)
        {


        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner?.Show();
        }
    }
}
