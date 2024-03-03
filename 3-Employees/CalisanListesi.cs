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
    public partial class CalisanListesi : Form
    {
        public CalisanListesi()
        {
            InitializeComponent();
        }

        List <Calisan> calisan = new List <Calisan>();
        int count = 0;

        public void CalisanEkle(Calisan yeniCalisan)
        {
            calisan.Add(yeniCalisan);
            listBox1.Items.Add("["+yeniCalisan.IdentityNo +"] - " + yeniCalisan.name + " " + yeniCalisan.Surname+" ("+yeniCalisan.Salary+" $)");
            count++;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bir Çalışan Seçiniz");
            }
            else
            {
                Calisan sil = calisan[listBox1.SelectedIndex];
                calisan.Remove(sil);
                listBox1.Items.Remove(listBox1.SelectedItem);
                count--;
            }
        }
    }
}
