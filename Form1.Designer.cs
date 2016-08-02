namespace TestOluşturmaProgramı
{
    partial class Form1
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
            this.cmbTest = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSorular = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoru = new System.Windows.Forms.Label();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.rdC = new System.Windows.Forms.RadioButton();
            this.rdD = new System.Windows.Forms.RadioButton();
            this.lblAnswerA = new System.Windows.Forms.Label();
            this.lblAnswerB = new System.Windows.Forms.Label();
            this.lblAnswerC = new System.Windows.Forms.Label();
            this.lblAnswerD = new System.Windows.Forms.Label();
            this.btnCevapla = new System.Windows.Forms.Button();
            this.btnTestEkle = new System.Windows.Forms.Button();
            this.btnSoruEkleDuzenle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTest
            // 
            this.cmbTest.FormattingEnabled = true;
            this.cmbTest.Location = new System.Drawing.Point(104, 9);
            this.cmbTest.Name = "cmbTest";
            this.cmbTest.Size = new System.Drawing.Size(202, 24);
            this.cmbTest.TabIndex = 0;
            this.cmbTest.SelectedIndexChanged += new System.EventHandler(this.cmbTest_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test Adı :";
            // 
            // lstSorular
            // 
            this.lstSorular.FormattingEnabled = true;
            this.lstSorular.ItemHeight = 16;
            this.lstSorular.Location = new System.Drawing.Point(104, 40);
            this.lstSorular.Name = "lstSorular";
            this.lstSorular.Size = new System.Drawing.Size(202, 356);
            this.lstSorular.TabIndex = 2;
            this.lstSorular.SelectedIndexChanged += new System.EventHandler(this.lstSorular_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sorular :";
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Location = new System.Drawing.Point(356, 28);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(0, 17);
            this.lblSoru.TabIndex = 4;
            // 
            // rdA
            // 
            this.rdA.AutoSize = true;
            this.rdA.Location = new System.Drawing.Point(347, 61);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(47, 21);
            this.rdA.TabIndex = 5;
            this.rdA.TabStop = true;
            this.rdA.Text = "A )";
            this.rdA.UseVisualStyleBackColor = true;
            // 
            // rdB
            // 
            this.rdB.AutoSize = true;
            this.rdB.Location = new System.Drawing.Point(347, 88);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(47, 21);
            this.rdB.TabIndex = 5;
            this.rdB.TabStop = true;
            this.rdB.Text = "B )";
            this.rdB.UseVisualStyleBackColor = true;
            // 
            // rdC
            // 
            this.rdC.AutoSize = true;
            this.rdC.Location = new System.Drawing.Point(347, 115);
            this.rdC.Name = "rdC";
            this.rdC.Size = new System.Drawing.Size(47, 21);
            this.rdC.TabIndex = 5;
            this.rdC.TabStop = true;
            this.rdC.Text = "C )";
            this.rdC.UseVisualStyleBackColor = true;
            // 
            // rdD
            // 
            this.rdD.AutoSize = true;
            this.rdD.Location = new System.Drawing.Point(347, 142);
            this.rdD.Name = "rdD";
            this.rdD.Size = new System.Drawing.Size(48, 21);
            this.rdD.TabIndex = 5;
            this.rdD.TabStop = true;
            this.rdD.Text = "D )";
            this.rdD.UseVisualStyleBackColor = true;
            // 
            // lblAnswerA
            // 
            this.lblAnswerA.AutoSize = true;
            this.lblAnswerA.Location = new System.Drawing.Point(400, 63);
            this.lblAnswerA.Name = "lblAnswerA";
            this.lblAnswerA.Size = new System.Drawing.Size(0, 17);
            this.lblAnswerA.TabIndex = 6;
            // 
            // lblAnswerB
            // 
            this.lblAnswerB.AutoSize = true;
            this.lblAnswerB.Location = new System.Drawing.Point(400, 90);
            this.lblAnswerB.Name = "lblAnswerB";
            this.lblAnswerB.Size = new System.Drawing.Size(0, 17);
            this.lblAnswerB.TabIndex = 6;
            // 
            // lblAnswerC
            // 
            this.lblAnswerC.AutoSize = true;
            this.lblAnswerC.Location = new System.Drawing.Point(400, 117);
            this.lblAnswerC.Name = "lblAnswerC";
            this.lblAnswerC.Size = new System.Drawing.Size(0, 17);
            this.lblAnswerC.TabIndex = 6;
            // 
            // lblAnswerD
            // 
            this.lblAnswerD.AutoSize = true;
            this.lblAnswerD.Location = new System.Drawing.Point(400, 144);
            this.lblAnswerD.Name = "lblAnswerD";
            this.lblAnswerD.Size = new System.Drawing.Size(0, 17);
            this.lblAnswerD.TabIndex = 6;
            // 
            // btnCevapla
            // 
            this.btnCevapla.Location = new System.Drawing.Point(645, 190);
            this.btnCevapla.Name = "btnCevapla";
            this.btnCevapla.Size = new System.Drawing.Size(75, 23);
            this.btnCevapla.TabIndex = 7;
            this.btnCevapla.Text = "Cevapla";
            this.btnCevapla.UseVisualStyleBackColor = true;
            // 
            // btnTestEkle
            // 
            this.btnTestEkle.Location = new System.Drawing.Point(325, 228);
            this.btnTestEkle.Name = "btnTestEkle";
            this.btnTestEkle.Size = new System.Drawing.Size(162, 69);
            this.btnTestEkle.TabIndex = 8;
            this.btnTestEkle.Text = "Test Ekle";
            this.btnTestEkle.UseVisualStyleBackColor = true;
            this.btnTestEkle.Click += new System.EventHandler(this.btnTestEkle_Click);
            // 
            // btnSoruEkleDuzenle
            // 
            this.btnSoruEkleDuzenle.Location = new System.Drawing.Point(509, 228);
            this.btnSoruEkleDuzenle.Name = "btnSoruEkleDuzenle";
            this.btnSoruEkleDuzenle.Size = new System.Drawing.Size(157, 69);
            this.btnSoruEkleDuzenle.TabIndex = 10;
            this.btnSoruEkleDuzenle.Text = "Soru Ekle Duzenle";
            this.btnSoruEkleDuzenle.UseVisualStyleBackColor = true;
            this.btnSoruEkleDuzenle.Click += new System.EventHandler(this.btnSoruEkleDuzenle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 419);
            this.Controls.Add(this.btnSoruEkleDuzenle);
            this.Controls.Add(this.btnTestEkle);
            this.Controls.Add(this.btnCevapla);
            this.Controls.Add(this.lblAnswerD);
            this.Controls.Add(this.lblAnswerC);
            this.Controls.Add(this.lblAnswerB);
            this.Controls.Add(this.lblAnswerA);
            this.Controls.Add(this.rdD);
            this.Controls.Add(this.rdC);
            this.Controls.Add(this.rdB);
            this.Controls.Add(this.rdA);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSorular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSorular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.RadioButton rdC;
        private System.Windows.Forms.RadioButton rdD;
        private System.Windows.Forms.Label lblAnswerA;
        private System.Windows.Forms.Label lblAnswerB;
        private System.Windows.Forms.Label lblAnswerC;
        private System.Windows.Forms.Label lblAnswerD;
        private System.Windows.Forms.Button btnCevapla;
        private System.Windows.Forms.Button btnTestEkle;
        private System.Windows.Forms.Button btnSoruEkleDuzenle;
    }
}

