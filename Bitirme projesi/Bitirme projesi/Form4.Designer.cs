namespace Bitirme_projesi
{
    partial class Form4
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Adana", "", "Adıyaman", "", "Afyonkarahisar", "", "Ağrı", "", "Aksaray", "", "Amasya", "", "Ankara", "", "Antalya", "", "Artvin", "", "Aydın", "", "Balıkesir", "", "Bartın", "", "Batman", "", "Bayburt", "", "Bilecik", "", "Bingöl", "", "Bitlis", "", "Bolu", "", "Burdur", "", "Bursa", "", "Çanakkale", "", "Çankırı", "", "Çorum", "", "Denizli", "", "Diyarbakır", "", "Düzce", "", "Edirne", "", "Elazığ", "", "Erzincan", "", "Erzurum", "", "Eskişehir", "", "Gaziantep", "", "Giresun", "", "Gümüşhane", "", "Hakkâri", "", "Hatay", "", "Iğdır", "", "Isparta", "", "İstanbul", "", "İzmir", "", "Kahramanmaraş", "", "Karabük", "", "Karaman", "", "Kars", "", "Kastamonu", "", "Kayseri", "", "Kırıkkale", "", "Kırklareli", "", "Kırşehir", "", "Kilis", "", "Konya", "", "Kütahya", "", "Malatya", "", "Manisa", "", "Mardin", "", "Mersin", "", "Muğla", "", "Muş", "", "Nevşehir", "", "Niğde", "", "Ordu", "", "Osmaniye", "", "Rize", "", "Sakarya", "", "Samsun", "", "Siirt", "", "Sinop", "", "Sivas", "", "Şanlıurfa", "", "Şırnak", "", "Tekirdağ", "", "Tokat", "", "Trabzon", "", "Tunceli", "", "Uşak", "", "Van", "", "Yalova", "", "Yozgat", "", "Zonguldak", "", "Ardahan", "", "Ağrı" });
            comboBox1.Location = new Point(111, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 67);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "İl SECİNİZ";
            // 
            // button1
            // 
            button1.Location = new Point(111, 237);
            button1.Name = "button1";
            button1.Size = new Size(119, 40);
            button1.TabIndex = 2;
            button1.Text = "restoranın sayfası";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 139);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 3;
            label2.Text = "İlinizdeki restoranlar";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(111, 136);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(140, 23);
            comboBox2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(329, 237);
            button2.Name = "button2";
            button2.Size = new Size(119, 40);
            button2.TabIndex = 5;
            button2.Text = "restoran ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 394);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "çıkıs yap";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(403, 333);
            button5.Name = "button5";
            button5.Size = new Size(119, 40);
            button5.TabIndex = 8;
            button5.Text = "siparislerimin durumu";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(364, 101);
            button6.Name = "button6";
            button6.Size = new Size(141, 23);
            button6.TabIndex = 9;
            button6.Text = "restoranları goster";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(835, 542);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private ComboBox comboBox2;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}