using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static Bitirme_projesi.Form3;

namespace Bitirme_projesi
{
    public partial class Form6 : Form
    {
        private decimal toplamFiyat = 0;

        public Form6()
        {
            InitializeComponent();
        }

        private MySqlConnection con = new MySqlConnection("Server=localhost;Database=bitirmeprojesi;Uid=root;Pwd=123456");

        private void Form6_Load(object sender, EventArgs e)
        {
            button3.Visible = false;

            if (GlobalData.kullanıcıadı == "g")
            {
                button3.Visible = true;
            }

            
            
                con.Open();
                PopulateComboBoxWithPrice("SELECT yemekadı, yemekfiyati FROM yemeklistesi", comboBox1);
                PopulateComboBoxWithPrice("SELECT icecekadı, icecekfiyati FROM iceceklistesi", comboBox2);
            PopulateComboBoxWithPrice("SELECT tatlıadı, fiyat FROM tatlılistesi", comboBox3);
                  con.Close();


        }

        private void PopulateComboBoxWithPrice(string query, ComboBox comboBox)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string itemName = reader[0].ToString();
                    decimal itemPrice = reader.GetDecimal(1);

                    string displayText = $"{itemName} - {itemPrice} TL";
                    comboBox.Items.Add(new ComboBoxItem
                    {
                        Text = displayText,
                        Value = new { Name = itemName, Price = itemPrice }
                    });
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;

            AddSelectedItemToListBox(comboBox1);
            AddSelectedItemToListBox(comboBox2);
            AddSelectedItemToListBox(comboBox3);

            label5.Text = $"Toplam Fiyat: {toplamFiyat} TL";
        }

        private void AddSelectedItemToListBox(ComboBox comboBox)
        {
            if (comboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                var itemValue = selectedItem.Value;
                string displayText = $"{itemValue.Name} - {itemValue.Price} TL";
                listBox1.Items.Add(displayText);

                toplamFiyat += itemValue.Price;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 restoranForm = new Form7();
            restoranForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MessageBox.Show($"Siparişiniz yola çıkmıştır. Ücretiniz: {toplamFiyat} TL");
            toplamFiyat = 0;
            label5.Text = "Toplam Fiyat: 0 TL";
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public dynamic Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}