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

namespace Stok_Takip_Uygulaması
{
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3S5VN4J;Initial Catalog=StokTakip;Integrated Security=True");
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into musteri values(@tc,@adsoyad,@adres,@email)", baglanti);
            komut.Parameters.AddWithValue("@tc", tbxTC.Text);
            komut.Parameters.AddWithValue("@adsoyad", tbxAdSoyad.Text);
            komut.Parameters.AddWithValue("@adres", tbxAdres.Text);
            komut.Parameters.AddWithValue("@email", tbxEmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydedildi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}