namespace Hospital1
{
    partial class Form3
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
            button4 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label7 = new Label();
            mySqlConnection1 = new MySqlConnector.MySqlConnection();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(980, 382);
            button4.Name = "button4";
            button4.Size = new Size(71, 29);
            button4.TabIndex = 40;
            button4.Text = "Hapus";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(899, 382);
            button3.Name = "button3";
            button3.Size = new Size(75, 29);
            button3.TabIndex = 39;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(448, 93);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(603, 283);
            dataGridView1.TabIndex = 38;
            // 
            // button2
            // 
            button2.Location = new Point(294, 357);
            button2.Name = "button2";
            button2.Size = new Size(112, 29);
            button2.TabIndex = 37;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(184, 309);
            comboBox1.MaxLength = 12;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 28);
            comboBox1.TabIndex = 33;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(184, 233);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(222, 27);
            textBox4.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 140);
            textBox2.MaxLength = 16;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 27);
            textBox2.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 27);
            textBox1.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 317);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 27;
            label6.Text = "Speasialisasi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 273);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 26;
            label5.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 236);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 25;
            label4.Text = "Tempat Lahir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 190);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 24;
            label3.Text = "Tanggal Lahir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 140);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 23;
            label2.Text = "NIK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 93);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 22;
            label1.Text = "Nama Lengkap";
            // 
            // button1
            // 
            button1.Location = new Point(46, 30);
            button1.Name = "button1";
            button1.Size = new Size(114, 29);
            button1.TabIndex = 21;
            button1.Text = " << Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(684, 44);
            label7.Name = "label7";
            label7.Size = new Size(181, 28);
            label7.TabIndex = 43;
            label7.Text = "Tabel Daftar Dokter";
            // 
            // mySqlConnection1
            // 
            mySqlConnection1.ProvideClientCertificatesCallback = null;
            mySqlConnection1.ProvidePasswordCallback = null;
            mySqlConnection1.RemoteCertificateValidationCallback = null;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(184, 271);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 24);
            radioButton1.TabIndex = 44;
            radioButton1.TabStop = true;
            radioButton1.Text = "Laki-laki";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(281, 271);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(104, 24);
            radioButton2.TabIndex = 45;
            radioButton2.TabStop = true;
            radioButton2.Text = "Perempuan";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(184, 190);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(222, 27);
            dateTimePicker1.TabIndex = 46;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(282, 31);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(124, 27);
            textBox3.TabIndex = 47;
            textBox3.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(184, 357);
            button5.Name = "button5";
            button5.Size = new Size(76, 29);
            button5.TabIndex = 48;
            button5.Text = "Reset";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(607, 382);
            button6.Name = "button6";
            button6.Size = new Size(81, 28);
            button6.TabIndex = 49;
            button6.Text = "Cari";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(448, 384);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(153, 27);
            textBox5.TabIndex = 50;
            textBox5.Text = "Cari Data Dokter";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 426);
            ControlBox = false;
            Controls.Add(textBox5);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Dokter";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button2;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label7;
        private MySqlConnector.MySqlConnection mySqlConnection1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private Button button5;
        private Button button6;
        private TextBox textBox5;
    }
}