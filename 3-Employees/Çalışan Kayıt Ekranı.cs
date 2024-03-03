using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Employees
{
    public partial class CalisanEkran : Form
    {
        public CalisanEkran()
        {
            InitializeComponent();
        }

        CalisanListesi formCalisan = new CalisanListesi();
        int sayac = 0;

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Calisan calisan = new Calisan();
            calisan.name = txtAd.Text;
            calisan.Surname = txtSoyad.Text;
            calisan.IdentityNo = txtKayit.Text;
            calisan.Salary = numMaas.Value;

            formCalisan.CalisanEkle(calisan);

            txtAd.Text = txtSoyad.Text = txtKayit.Text = "";
            numMaas.Value = 0;
            txtKayit.Focus();
            sayac++;
        }

        private void CalisanEkran_Load(object sender, EventArgs e)
        {
            formCalisan.Show();
        }
    }
}
