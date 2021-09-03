using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hastane_Otomasyon
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public string TC;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC;

            //Doktor Ad Soyad
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevular 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='" + lblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle fr = new FrmDoktorBilgiDüzenle();
            fr.TCNO = lblTC.Text;
            fr.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void BtnÇıkış_Click(object sender, EventArgs e)
        {
            FrmGirisler fr = new FrmGirisler();
            fr.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchŞikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris fr = new FrmDoktorGiris();
            fr.Show();
        }
    }
}
