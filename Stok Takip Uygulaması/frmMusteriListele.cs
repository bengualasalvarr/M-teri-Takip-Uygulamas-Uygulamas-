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

namespace Stok_Takip_Uygulaması
{
    public partial class frmMusteriListele : Form
    {
        public frmMusteriListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3S5VN4J;Initial Catalog=StokTakip;Integrated Security=True");
        DataSet daset= new DataSet();
        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            kayitGoster();
        }
        private void kayitGoster()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM musteri", baglanti);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE musteri SET adsoyad=@adsoyad, adres=@adres, email=@email WHERE tc=@tc", baglanti);
                komut.Parameters.AddWithValue("@tc", tbxTC.Text);
                komut.Parameters.AddWithValue("@adsoyad", tbxAdSoyad.Text);
                komut.Parameters.AddWithValue("@adres", tbxAdres.Text);
                komut.Parameters.AddWithValue("@email", tbxEmail.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Müşteri Kaydı Güncellendi.");


                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM musteri", baglanti);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                baglanti.Close();
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM musteri WHERE tc='" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi.");
                baglanti.Close();
                dataGridView1.DataSource = null;
                kayitGoster();
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbxTC.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            tbxAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            tbxAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            tbxEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
        }
        
    }
}