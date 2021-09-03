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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterDetay frs = new FrmSekreterDetay();
                frs.TCnumara = MskTC.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc & Şifre");
            }
            bgl.baglanti().Close();
        }

        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGirisler fr = new FrmGirisler();
            fr.Show();
        }
    }
}
