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

namespace Bitirme_projesi
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=bitirmeprojesi;Uid=root;Pwd=123456");
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from siparisler", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string durum = reader["siparis_durumu"].ToString();
                string ad = reader["siparisi_veren_adi"].ToString();
                string siparislistesi = reader["siparislistesi"].ToString();
                string siparisfiyati = reader["siparisfiyati"].ToString();
                listBox1.Items.Add($"{durum} - {ad} - {siparislistesi} - {siparisfiyati}"); 
            }

            con.Close();

        }
    }
}
