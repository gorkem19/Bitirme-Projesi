namespace Bitirme_projesi
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 50F);
            label1.Location = new Point(98, 0);
            label1.Name = "label1";
            label1.Size = new Size(730, 91);
            label1.TabIndex = 0;
            label1.Text = "restoran ekleme sayfası";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 124);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "restoran adı";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 195);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 3;
            label3.Text = "adres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 279);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 4;
            label4.Text = "telefon";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(164, 195);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(164, 271);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(145, 430);
            button1.Name = "button1";
            button1.Size = new Size(140, 55);
            button1.TabIndex = 7;
            button1.Text = "restoranı ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 338);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 8;
            label5.Text = "il";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Adana", "", "Adıyaman", "", "Afyonkarahisar", "", "Ağrı", "", "Aksaray", "", "Amasya", "", "Ankara", "", "Antalya", "", "Ardahan", "", "Artvin", "", "Aydın", "", "Balıkesir", "", "Bartın", "", "Batman", "", "Bayburt", "", "Bilecik", "", "Bingöl", "", "Bitlis", "", "Bolu", "", "Burdu", "", "Bursa", "", "Çanakkale", "", "Çankırı", "", "Çorum", "", "Denizli", "", "Diyarbakır", "", "Düzce", "", "Edirne", "", "Elazığ", "", "Erzincan", "", "Erzurum", "", "Eskişehir", "", "Gaziantep", "", "Giresun", "", "Gümüşhane", "", "Hakkâri", "", "Hatay", "", "Iğdır", "", "Isparta", "", "İstanbul", "", "İzmir", "", "Kahramanmaraş", "", "Karabük", "", "Karaman", "", "Kars", "", "Kastamonu", "", "Kayseri", "", "Kırıkkale", "", "Kırklareli", "", "Kırşehir", "", "Kilis", "", "Kocaeli", "", "Konya", "", "Kütahya", "", "Malatya", "", "Manisa", "", "Mardin", "", "Mersin", "", "Muğla", "", "Muş", "", "Nevşehir", "", "Niğde", "", "Ordu", "", "Osmaniye", "", "Rize", "", "Sakarya", "", "Samsun", "", "Şanlıurfa", "", "Siirt", "", "Sinop", "", "Sivas", "", "Şırnak", "", "Tekirdağ", "", "Tokat", "", "Trabzon", "", "Tunceli", "", "Uşak", "", "Van", "", "Yalova", "", "Yozgat", "", "Zonguldak" });
            comboBox1.Location = new Point(164, 338);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(984, 540);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label5;
        private ComboBox comboBox1;
    }
}