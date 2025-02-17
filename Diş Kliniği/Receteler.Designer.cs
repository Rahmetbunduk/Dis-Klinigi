
namespace Diş_Kliniği
{
    partial class Receteler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receteler));
            this.MiktarTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TutarTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TedaviTb = new System.Windows.Forms.TextBox();
            this.AraTB = new System.Windows.Forms.TextBox();
            this.ReceteDGV = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HastaASCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IlaclarTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReceteDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MiktarTb
            // 
            this.MiktarTb.BackColor = System.Drawing.Color.Gainsboro;
            this.MiktarTb.Location = new System.Drawing.Point(194, 439);
            this.MiktarTb.Multiline = true;
            this.MiktarTb.Name = "MiktarTb";
            this.MiktarTb.Size = new System.Drawing.Size(204, 36);
            this.MiktarTb.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(93, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 84;
            this.label6.Text = "Miktar :";
            // 
            // TutarTb
            // 
            this.TutarTb.BackColor = System.Drawing.Color.Gainsboro;
            this.TutarTb.Location = new System.Drawing.Point(194, 375);
            this.TutarTb.Multiline = true;
            this.TutarTb.Name = "TutarTb";
            this.TutarTb.Size = new System.Drawing.Size(204, 36);
            this.TutarTb.TabIndex = 83;
            this.TutarTb.TextChanged += new System.EventHandler(this.TutarTb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(103, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 82;
            this.label5.Text = "Tutarı :";
            // 
            // TedaviTb
            // 
            this.TedaviTb.BackColor = System.Drawing.Color.Gainsboro;
            this.TedaviTb.Location = new System.Drawing.Point(198, 247);
            this.TedaviTb.Multiline = true;
            this.TedaviTb.Name = "TedaviTb";
            this.TedaviTb.Size = new System.Drawing.Size(204, 36);
            this.TedaviTb.TabIndex = 81;
            this.TedaviTb.TextChanged += new System.EventHandler(this.TedaviTb_TextChanged);
            // 
            // AraTB
            // 
            this.AraTB.BackColor = System.Drawing.Color.Gainsboro;
            this.AraTB.Location = new System.Drawing.Point(746, 177);
            this.AraTB.Multiline = true;
            this.AraTB.Name = "AraTB";
            this.AraTB.Size = new System.Drawing.Size(204, 27);
            this.AraTB.TabIndex = 78;
            this.AraTB.TextChanged += new System.EventHandler(this.AraTb_TextChanged);
            // 
            // ReceteDGV
            // 
            this.ReceteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceteDGV.Location = new System.Drawing.Point(567, 210);
            this.ReceteDGV.Name = "ReceteDGV";
            this.ReceteDGV.RowHeadersWidth = 51;
            this.ReceteDGV.RowTemplate.Height = 24;
            this.ReceteDGV.Size = new System.Drawing.Size(580, 345);
            this.ReceteDGV.TabIndex = 77;
            this.ReceteDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReceteDGV_CellClick);
            this.ReceteDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReceteDGV_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(262, 515);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 40);
            this.button3.TabIndex = 76;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(62, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 40);
            this.button1.TabIndex = 74;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(51, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 73;
            this.label3.Text = "Tedavi Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(476, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 22);
            this.label4.TabIndex = 72;
            this.label4.Text = "MARAŞ DENTAL KLİNİK";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 100);
            this.panel1.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Diş_Kliniği.Properties.Resources.DisLogosu;
            this.pictureBox1.Location = new System.Drawing.Point(99, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // HastaASCb
            // 
            this.HastaASCb.BackColor = System.Drawing.Color.Gainsboro;
            this.HastaASCb.FormattingEnabled = true;
            this.HastaASCb.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.HastaASCb.Location = new System.Drawing.Point(198, 195);
            this.HastaASCb.Name = "HastaASCb";
            this.HastaASCb.Size = new System.Drawing.Size(200, 24);
            this.HastaASCb.TabIndex = 87;
            this.HastaASCb.SelectedIndexChanged += new System.EventHandler(this.HastaASCb_SelectedIndexChanged);
            this.HastaASCb.SelectionChangeCommitted += new System.EventHandler(this.HastaASCb_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(58, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 23);
            this.label7.TabIndex = 86;
            this.label7.Text = "Ad Soyad :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tan;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(790, 561);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 41);
            this.button2.TabIndex = 88;
            this.button2.Text = "YAZDIR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1132, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button7.ForeColor = System.Drawing.Color.LightGray;
            this.button7.Location = new System.Drawing.Point(933, 29);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 38);
            this.button7.TabIndex = 9;
            this.button7.Text = "REÇETELER";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(706, 29);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 38);
            this.button8.TabIndex = 8;
            this.button8.Text = "TEDAVİ";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(483, 29);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 38);
            this.button9.TabIndex = 7;
            this.button9.Text = "RANDEVU";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(272, 32);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(133, 35);
            this.button10.TabIndex = 6;
            this.button10.Text = "HASTA";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "<<<";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IlaclarTb
            // 
            this.IlaclarTb.BackColor = System.Drawing.Color.Gainsboro;
            this.IlaclarTb.Location = new System.Drawing.Point(198, 311);
            this.IlaclarTb.Multiline = true;
            this.IlaclarTb.Name = "IlaclarTb";
            this.IlaclarTb.Size = new System.Drawing.Size(204, 36);
            this.IlaclarTb.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(92, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 23);
            this.label8.TabIndex = 90;
            this.label8.Text = "İlaçlar :";
            // 
            // Receteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1166, 625);
            this.Controls.Add(this.IlaclarTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.HastaASCb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MiktarTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TutarTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TedaviTb);
            this.Controls.Add(this.AraTB);
            this.Controls.Add(this.ReceteDGV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "Receteler";
            this.Text = "Reçeteler";
            this.Load += new System.EventHandler(this.Receteler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReceteDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MiktarTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TutarTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TedaviTb;
        private System.Windows.Forms.TextBox AraTB;
        private System.Windows.Forms.DataGridView ReceteDGV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox HastaASCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IlaclarTb;
        private System.Windows.Forms.Label label8;
    }
}