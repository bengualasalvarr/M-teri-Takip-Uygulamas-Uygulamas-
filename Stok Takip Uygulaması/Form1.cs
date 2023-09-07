using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblGirisYazisi.Font = new Font(lblGirisYazisi.Font.FontFamily, 30);
            lblListeleme.Font = new Font(lblListeleme.Font.FontFamily, 15);
            lblMusteriEkleme.Font=new Font(lblMusteriEkleme.Font.FontFamily, 15);

        }

        private void btnMusteriEkleme_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle=new frmMusteriEkle();
            ekle.ShowDialog();
        }

        private void btnListeleme_Click(object sender, EventArgs e)
        {
            frmMusteriListele listele=new frmMusteriListele();
            listele.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
