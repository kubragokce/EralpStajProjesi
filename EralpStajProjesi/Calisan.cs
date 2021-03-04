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

namespace EralpStajProjesi
{
    public partial class Calisan : Form
    {
        public Calisan()
        {
            InitializeComponent();
        }
        //Data Source=LAPTOP-DE6TC4RE;Initial Catalog=eralpstaj;Integrated Security=True
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-DE6TC4RE;Initial Catalog=eralpstaj;Integrated Security=True");
        private void Calisan_Load(object sender, EventArgs e)
        {
            this.calisanTableAdapter.Fill(this.eralpstajDataSet.Calisan);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand guncelle = new SqlCommand("Update Calisan set FirmaID=@yenifirma where CalisanID=@id ", con);
            guncelle.Parameters.AddWithValue("@yenifirma", textBoxYeniFirmaID.Text);
            guncelle.Parameters.AddWithValue("@id", textBoxID.Text);
            guncelle.ExecuteNonQuery();

            this.calisanTableAdapter.Fill(this.eralpstajDataSet.Calisan);

            con.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand ekle = new SqlCommand("INSERT INTO Calisan(CalisanAdiSoyadi,FirmaID,DepartmanID) VALUES(@calisanadisoyadi,@firmaid,@departmanid)", con);
            ekle.Parameters.AddWithValue("@calisanadisoyadi", textBoxAdSoyad.Text);
            ekle.Parameters.AddWithValue("@firmaid", textBoxFirmaID.Text);
            ekle.Parameters.AddWithValue("@departmanid", textBoxDepartmanID.Text);
            ekle.ExecuteNonQuery();

            this.calisanTableAdapter.Fill(this.eralpstajDataSet.Calisan);

            con.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand sil = new SqlCommand("Delete from Calisan where CalisanID=@calisanid", con);
            sil.Parameters.AddWithValue("@calisanid", textBoxCalisanID.Text);
            sil.ExecuteNonQuery();

            this.calisanTableAdapter.Fill(this.eralpstajDataSet.Calisan);

            con.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            this.Hide();
            giris.ShowDialog();
            this.Close();
        }
    }
}
