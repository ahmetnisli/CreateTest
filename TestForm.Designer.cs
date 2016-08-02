namespace TestOluşturmaProgramı
{
    partial class TestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTestAd = new System.Windows.Forms.TextBox();
            this.txtOgrtmnAdi = new System.Windows.Forms.TextBox();
            this.dtBasZaman = new System.Windows.Forms.DateTimePicker();
            this.dtBtsZaman = new System.Windows.Forms.DateTimePicker();
            this.numSoruAdet = new System.Windows.Forms.NumericUpDown();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSoruAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Başlangıç Zamanı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bitiş Zamanı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soru Adedi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Öğretmen Adı :";
            // 
            // txtTestAd
            // 
            this.txtTestAd.Location = new System.Drawing.Point(146, 36);
            this.txtTestAd.Name = "txtTestAd";
            this.txtTestAd.Size = new System.Drawing.Size(151, 22);
            this.txtTestAd.TabIndex = 5;
            // 
            // txtOgrtmnAdi
            // 
            this.txtOgrtmnAdi.Location = new System.Drawing.Point(146, 199);
            this.txtOgrtmnAdi.Name = "txtOgrtmnAdi";
            this.txtOgrtmnAdi.Size = new System.Drawing.Size(151, 22);
            this.txtOgrtmnAdi.TabIndex = 5;
            // 
            // dtBasZaman
            // 
            this.dtBasZaman.CustomFormat = "";
            this.dtBasZaman.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBasZaman.Location = new System.Drawing.Point(146, 73);
            this.dtBasZaman.Name = "dtBasZaman";
            this.dtBasZaman.Size = new System.Drawing.Size(151, 22);
            this.dtBasZaman.TabIndex = 6;
            // 
            // dtBtsZaman
            // 
            this.dtBtsZaman.CustomFormat = "";
            this.dtBtsZaman.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBtsZaman.Location = new System.Drawing.Point(146, 114);
            this.dtBtsZaman.Name = "dtBtsZaman";
            this.dtBtsZaman.Size = new System.Drawing.Size(151, 22);
            this.dtBtsZaman.TabIndex = 6;
            // 
            // numSoruAdet
            // 
            this.numSoruAdet.Location = new System.Drawing.Point(146, 158);
            this.numSoruAdet.Name = "numSoruAdet";
            this.numSoruAdet.Size = new System.Drawing.Size(151, 22);
            this.numSoruAdet.TabIndex = 7;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(146, 245);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 8;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(227, 245);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 339);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.numSoruAdet);
            this.Controls.Add(this.dtBtsZaman);
            this.Controls.Add(this.dtBasZaman);
            this.Controls.Add(this.txtOgrtmnAdi);
            this.Controls.Add(this.txtTestAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            ((System.ComponentModel.ISupportInitialize)(this.numSoruAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtTestAd;
        public System.Windows.Forms.TextBox txtOgrtmnAdi;
        public System.Windows.Forms.DateTimePicker dtBasZaman;
        public System.Windows.Forms.DateTimePicker dtBtsZaman;
        public System.Windows.Forms.NumericUpDown numSoruAdet;
        public System.Windows.Forms.Button btnIptal;
        public System.Windows.Forms.Button btnEkle;
    }
}