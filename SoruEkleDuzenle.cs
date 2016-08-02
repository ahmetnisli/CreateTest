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
    public partial class SoruEkleDuzenle : Form
    {
        public SoruEkleDuzenle()
        {
            InitializeComponent();
        }
        string ConnectionString = "Server=.;Database=TestOlusturma;Integrated Security=true";

        public int index,sorusayisi;
        private void lstTestSorular_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTestSorular.SelectedIndex > -1)
            {
                Soru soru = lstTestSorular.SelectedItem as Soru;
                txtA.Text = soru.AnswerA;
                txtB.Text = soru.AnswerB;
                txtC.Text = soru.AnswerC;
                txtD.Text = soru.AnswerD;
                txtSoru.Text = soru.Text;
                cmbDogru.SelectedItem = soru.Answer;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lstTestSorular.Items.Count < sorusayisi)
            {
                AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
                string query = "Insert into Soru Values(@text,@ans1,@ans2,@ans3,@ans4,@corrans,@testID)";
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@text", txtSoru.Text));
                lst.Add(new SqlParameter("@ans1", txtA.Text));
                lst.Add(new SqlParameter("@ans2", txtB.Text));
                lst.Add(new SqlParameter("@ans3", txtC.Text));
                lst.Add(new SqlParameter("@ans4", txtD.Text));
                lst.Add(new SqlParameter("@corrans", cmbDogru.SelectedItem.ToString()));
                lst.Add(new SqlParameter("testID", index));
                ado.RunQuery(query, lst);
                SorulariGoster();
            }
            else
            {
                MessageBox.Show("Test Için Belirlenen Soru Sayısı Tamamlanmıştır!!!");
            }
        }

        private void SorulariGoster()
        {
            lstTestSorular.Items.Clear();
            AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
            string query = "Select * from Soru where TestID=@test";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter("@test", index));
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
                soru.TestID = index;
                lstTestSorular.Items.Add(soru);

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstTestSorular.SelectedIndex > -1)
            {
                AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
                Soru soru = lstTestSorular.SelectedItem as Soru;
                string query = "Delete from Soru where QuestionID=@id";
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@id", soru.SoruId));
                ado.RunQuery(query, lst);
                SorulariGoster();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Soru Seçiniz!!!");
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (lstTestSorular.SelectedIndex > -1 )
            {
                AdoNetHelper.Database ado = new AdoNetHelper.Database(ConnectionString);
                Soru soru = lstTestSorular.SelectedItem as Soru;
                string query = "Update Soru set QuestionText=@text,Answer1=@ans1,Answer2=@ans2,Answer3=@ans3,Answer4=@ans4,Answer=@corrans,TestID=@testID  where QuestionID=@id";
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@text", txtSoru.Text));
                lst.Add(new SqlParameter("@ans1", txtA.Text));
                lst.Add(new SqlParameter("@ans2", txtB.Text));
                lst.Add(new SqlParameter("@ans3", txtC.Text));
                lst.Add(new SqlParameter("@ans4", txtD.Text));
                lst.Add(new SqlParameter("@corrans", cmbDogru.SelectedItem.ToString()));
                lst.Add(new SqlParameter("@testID", index));
                lst.Add(new SqlParameter("@id", soru.SoruId));
                ado.RunQuery(query, lst);
                SorulariGoster();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Soru Seçiniz!!!");
            }
        }
    }
}
