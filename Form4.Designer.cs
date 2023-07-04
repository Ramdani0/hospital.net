namespace Hospital1
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
            label7 = new Label();
            textBox6 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(598, 85);
            label7.Name = "label7";
            label7.Size = new Size(165, 28);
            label7.TabIndex = 64;
            label7.Text = "Tabel Daftar Obat";
            // 
            // textBox6
            // 
            textBox6.AcceptsReturn = true;
            textBox6.BackColor = SystemColors.Control;
            textBox6.Location = new Point(398, 392);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(336, 27);
            textBox6.TabIndex = 62;
            textBox6.Text = "Cari Data Obat";
            // 
            // button4
            // 
            button4.Location = new Point(878, 391);
            button4.Name = "button4";
            button4.Size = new Size(71, 29);
            button4.TabIndex = 61;
            button4.Text = "Hapus";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(797, 390);
            button3.Name = "button3";
            button3.Size = new Size(75, 29);
            button3.TabIndex = 60;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(398, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(551, 252);
            dataGridView1.TabIndex = 59;
            // 
            // button2
            // 
            button2.Location = new Point(201, 289);
            button2.Name = "button2";
            button2.Size = new Size(149, 29);
            button2.TabIndex = 58;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(185, 233);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(190, 27);
            textBox4.TabIndex = 54;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(185, 190);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 27);
            textBox3.TabIndex = 53;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 27);
            textBox2.TabIndex = 52;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 236);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 48;
            label4.Text = "Harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 190);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 47;
            label3.Text = "Kuantitas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 140);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 46;
            label2.Text = "Indikasi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 93);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 45;
            label1.Text = "Nama Obat";
            // 
            // button1
            // 
            button1.Location = new Point(46, 30);
            button1.Name = "button1";
            button1.Size = new Size(114, 29);
            button1.TabIndex = 44;
            button1.Text = " << Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 450);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Obat";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox textBox6;
        private Button button4;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}