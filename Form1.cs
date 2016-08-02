using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOluşturmaProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       string ConnectionString = "Server=.;Database=TestOlusturma;Integrated Security=true";
        private void Form1_Load(object sender, EventArgs e)
        {
            TestleriGetir();
        }

        private void TestleriGetir()
        {
            lstSorular.Items.Clear();
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            string query = "Select * from Testler";
            DataTable dt = ado.getData(query, new List<SqlParameter>());
            foreach (DataRow item in dt.Rows)
            {
                Test test = new Test();
                test.Id = (int)item["TestID"];
                test.Name = item["TestName"].ToString();
                test.StartDate = (DateTime)item["StartDate"];
                test.EndDate = (DateTime)item["FinishDate"];
                test.QuestionQuantity = (int)item["QuestionQuantity"];
                test.TeacherName = item["TeacherName"].ToString();
                cmbTest.Items.Add(test);
            }
        }

        private void cmbTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            TestSorulariniGetir();
           
        }

        private void TestSorulariniGetir()
        {

            if (cmbTest.SelectedIndex > -1)
            {
                lstSorular.Items.Clear();
                AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
                Test test = (Test)cmbTest.SelectedItem;
                string query = "Select * from Soru where TestID=@test";
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@test", test.Id));
                DataTable dt = ado.getData(query, lst);
                foreach (DataRow item in dt.Rows)
                {
                    Soru soru = new Soru();
                    soru.SoruId = (int)item["QuestionID"];
                    soru.Text = item["QuestionText"].ToString();
                    soru.AnswerA = item["Answer1"].ToString();
                    soru.AnswerB = item["Answer2"].ToString();
                    soru.AnswerC = item["Answer3"].ToString();
                    soru.AnswerD = item["Answer4"].ToString();
                    soru.Answer = item["Answer"].ToString();
                    soru.TestID = test.Id;
                    lstSorular.Items.Add(soru);

                }
            }
        }

        private void lstSorular_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSorular.SelectedIndex > -1)
            {
                Soru soru = lstSorular.SelectedItem as Soru;
                lblSoru.Text = soru.Text;
                lblAnswerA.Text = soru.AnswerA;
                lblAnswerB.Text = soru.AnswerB;
                lblAnswerC.Text = soru.AnswerC;
                lblAnswerD.Text = soru.AnswerD;
            }
        }

        private void btnTestEkle_Click(object sender, EventArgs e)
        {
            TestForm tst = new TestForm();
            DialogResult dia=tst.ShowDialog();
            if (dia == DialogResult.OK)
            {
                AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
                string query = "Insert into Testler Values(@name,@start,@end,@quantity,@teachname)";
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@name", tst.txtTestAd.Text));
                lst.Add(new SqlParameter("@start", tst.dtBasZaman.Value));
                lst.Add(new SqlParameter("@end", tst.dtBtsZaman.Value));
                lst.Add(new SqlParameter("@quantity", tst.numSoruAdet.Value));
                lst.Add(new SqlParameter("@teachname", tst.txtOgrtmnAdi.Text));
                ado.RunQuery(query, lst);
                TestleriGetir();
            }
        }

        private void btnSoruEkleDuzenle_Click(object sender, EventArgs e)
        {
            SoruEkleDuzenle soruform = new SoruEkleDuzenle();
            if (cmbTest.SelectedIndex > -1)
            {
                Test test = cmbTest.SelectedItem as Test;
                soruform.lblTestAdi.Text = test.Name;
                soruform.index = test.Id;
                soruform.sorusayisi = test.QuestionQuantity;
                AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
                string query = "Select * from Soru where TestID=@test";
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@test", test.Id));
                DataTable dt = ado.getData(query, lst);
                foreach (DataRow item in dt.Rows)
                {
                    Soru soru = new Soru();
                    soru.SoruId = (int)item["QuestionID"];
                    soru.Text = item["QuestionText"].ToString();
                    soru.AnswerA = item["Answer1"].ToString();
                    soru.AnswerB = item["Answer2"].ToString();
                    soru.AnswerC = item["Answer3"].ToString();
                    soru.AnswerD = item["Answer4"].ToString();
                    soru.Answer = item["Answer"].ToString();
                    soru.TestID = test.Id;
                    soruform.lstTestSorular.Items.Add(soru);

                }
                soruform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Test Seçiniz !!!");
            }
            TestSorulariniGetir();
        }
    }
}
