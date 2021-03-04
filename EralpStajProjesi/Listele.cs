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
    public partial class Listele : Form
    {
        public Listele()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-DE6TC4RE;Initial Catalog=eralpstaj;Integrated Security=True");

        private void Departman_Load(object sender, EventArgs e)
        {
            con.Open();

            CalisanTablosunuDoldur(con);
            CalisanSayisiHesapla(con);

            // TODO: This line of code loads data into the 'eralpstajDataSet.Firma' table. You can move, or remove it, as needed.
            this.firmaTableAdapter.Fill(this.eralpstajDataSet.Firma);
            // TODO: This line of code loads data into the 'eralpstajDataSet.Departman' table. You can move, or remove it, as needed.
            this.departmanTableAdapter.Fill(this.eralpstajDataSet.Departman);

            con.Close();
        }

        public void CalisanTablosunuDoldur(SqlConnection con)
        {

            SqlDataAdapter goster = new SqlDataAdapter("Select * from Calisan order by CalisanID desc ", con);
            DataSet ds = new DataSet();
            goster.Fill(ds);
            dataGridViewCalisan.DataSource = ds.Tables[0];

        }
        public void CalisanSayisiHesapla(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("CalisanSayisiniHesapla",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

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
