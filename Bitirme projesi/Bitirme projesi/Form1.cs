using MySql.Data.MySqlClient;
using System.Data;
namespace Bitirme_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 uyeForm = new Form2();
            uyeForm.Owner = this;
            uyeForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=bitirmeprojesi;Uid=root;Pwd=123456");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 girisForm = new Form3();
            girisForm.Owner = this;
            girisForm.Show();
            this.Hide(); 
        }
    }
}
