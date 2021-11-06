using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        // 1 ise KOLAY
        // 2 ise ORTA
        // 3 ise ZOR
        private void btnKolaySeviye_Click(object sender, EventArgs e)
        {
            // Oyun formunu kolay seviyede aç
            OyunEkrani oyunEkrani = new OyunEkrani(1);
            oyunEkrani.ShowDialog();
        }

        private void btnOrtaSeviye_Click(object sender, EventArgs e)
        {
            // Oyun formunu orta seviyede aç
            OyunEkrani oyunEkrani = new OyunEkrani(2);
            oyunEkrani.ShowDialog();
        }

        private void btnZorSeviye_Click(object sender, EventArgs e)
        {
            // Oyun formunu zor seviyede aç
            OyunEkrani oyunEkrani = new OyunEkrani(3);
            oyunEkrani.ShowDialog();
        }
    }
}
