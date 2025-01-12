namespace Bitirme_projesi
{
    partial class Form6
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button2 = new Button();
            label5 = new Label();
            button3 = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(145, 139);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 139);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "yemek listesi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 215);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "icicekler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 45F);
            label3.Location = new Point(331, 9);
            label3.Name = "label3";
            label3.Size = new Size(0, 81);
            label3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 291);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 5;
            label4.Text = "tatlılar";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(145, 215);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(145, 291);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(145, 370);
            button2.Name = "button2";
            button2.Size = new Size(103, 53);
            button2.TabIndex = 8;
            button2.Text = "sepete ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(471, 474);
            label5.Name = "label5";
            label5.Size = new Size(131, 25);
            label5.TabIndex = 9;
            label5.Text = "Urunlerin ucreti";
            // 
            // button3
            // 
            button3.Location = new Point(312, 139);
            button3.Name = "button3";
            button3.Size = new Size(115, 47);
            button3.TabIndex = 10;
            button3.Text = "restoranı duzenle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(312, 232);
            button1.Name = "button1";
            button1.Size = new Size(115, 47);
            button1.TabIndex = 0;
            button1.Text = "Siparis Ver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(447, 24);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(510, 424);
            listBox1.TabIndex = 11;
            // 
            // button4
            // 
            button4.Location = new Point(15, 588);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 12;
            button4.Text = "geri";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(575, 528);
            button5.Name = "button5";
            button5.Size = new Size(111, 42);
            button5.TabIndex = 13;
            button5.Text = "Sepetten Cıkar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(981, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(439, 414);
            dataGridView1.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1135, 24);
            label6.Name = "label6";
            label6.Size = new Size(183, 15);
            label6.TabIndex = 15;
            label6.Text = "Bu Restoran Hakkındaki Yorumlar";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1009, 582);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(9, 8);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(981, 462);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(425, 129);
            textBox1.TabIndex = 17;
            // 
            // button6
            // 
            button6.Location = new Point(1053, 597);
            button6.Name = "button6";
            button6.Size = new Size(293, 29);
            button6.TabIndex = 18;
            button6.Text = "Yorumu Gonder";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1432, 638);
            Controls.Add(button6);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button2;
        private Label label5;
        private Button button3;
        private Button button1;
        private ListBox listBox1;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private Label label6;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button6;
    }
}