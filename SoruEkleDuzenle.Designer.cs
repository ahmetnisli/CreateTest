namespace TestOluşturmaProgramı
{
    partial class SoruEkleDuzenle
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
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDogru = new System.Windows.Forms.ComboBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.lstTestSorular = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTestAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(499, 252);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDuzenle.TabIndex = 18;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(387, 252);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(277, 252);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "D :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "C :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "B :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "A :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dogru :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Soru :";
            // 
            // cmbDogru
            // 
            this.cmbDogru.FormattingEnabled = true;
            this.cmbDogru.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbDogru.Location = new System.Drawing.Point(277, 97);
            this.cmbDogru.Name = "cmbDogru";
            this.cmbDogru.Size = new System.Drawing.Size(309, 24);
            this.cmbDogru.TabIndex = 11;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(277, 211);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(309, 22);
            this.txtD.TabIndex = 6;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(277, 183);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(309, 22);
            this.txtC.TabIndex = 7;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(277, 153);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(309, 22);
            this.txtB.TabIndex = 8;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(277, 126);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(309, 22);
            this.txtA.TabIndex = 9;
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(277, 67);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(309, 22);
            this.txtSoru.TabIndex = 10;
            // 
            // lstTestSorular
            // 
            this.lstTestSorular.FormattingEnabled = true;
            this.lstTestSorular.ItemHeight = 16;
            this.lstTestSorular.Location = new System.Drawing.Point(12, 62);
            this.lstTestSorular.Name = "lstTestSorular";
            this.lstTestSorular.Size = new System.Drawing.Size(198, 260);
            this.lstTestSorular.TabIndex = 21;
            this.lstTestSorular.SelectedIndexChanged += new System.EventHandler(this.lstTestSorular_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Test Adı :";
            // 
            // lblTestAdi
            // 
            this.lblTestAdi.AutoSize = true;
            this.lblTestAdi.Location = new System.Drawing.Point(86, 25);
            this.lblTestAdi.Name = "lblTestAdi";
            this.lblTestAdi.Size = new System.Drawing.Size(46, 17);
            this.lblTestAdi.TabIndex = 23;
            this.lblTestAdi.Text = "label2";
            // 
            // SoruEkleDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 354);
            this.Controls.Add(this.lblTestAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTestSorular);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDogru);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtSoru);
            this.Name = "SoruEkleDuzenle";
            this.Text = "SoruEkleDuzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnDuzenle;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbDogru;
        public System.Windows.Forms.TextBox txtD;
        public System.Windows.Forms.TextBox txtC;
        public System.Windows.Forms.TextBox txtB;
        public System.Windows.Forms.TextBox txtA;
        public System.Windows.Forms.TextBox txtSoru;
        public System.Windows.Forms.ListBox lstTestSorular;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTestAdi;
    }
}