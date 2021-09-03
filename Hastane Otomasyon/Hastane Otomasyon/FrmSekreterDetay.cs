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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCnumara;
        public string secilen;
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCnumara;
            Txtid.Text = secilen;
            //Ad Soyad

            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",lblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                 lblAdSoyad.Text=dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları DataGride Aktarma 
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları Listeye Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar' ,DoktorBrans From Tbl_Doktorlar",bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı Comboboxa Aktarma 
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", MskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", CmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", CmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",CmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbDoktor.Items.Add(dr[0]+" "+dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", RchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frm = new FrmDoktorPaneli();
            frm.Show();
            this.Hide();
        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBrans frm = new FrmBrans();
            frm.Show();
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frm = new FrmRandevuListesi();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGirisler fr = new FrmGirisler();
            fr.Show();
        }

        private void Txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
