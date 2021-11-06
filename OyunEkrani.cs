using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class OyunEkrani : Form
    {
        // 1 ise KOLAY
        // 2 ise ORTA
        // 3 ise ZOR

        int hakSayisi = 0;
        int tahminSayisi = 0;
        int seviye = 0;
        public OyunEkrani(int seviye)
        {
            InitializeComponent();
            this.seviye = seviye;
            SeviyeyiAyarla(seviye);
            tahminSayisi = new Random().Next(0, 100);
        }

        private void SeviyeyiAyarla(int seviye)
        {
            // burada label değiştir hak sayısını değiştir
            if (seviye == 1)
            {
                lblSeviye.Text = "KOLAY SEVİYE";
                hakSayisi = 10;
                lblKalanHak.Text = hakSayisi.ToString();
            }
            else if (seviye == 2)
            {
                lblSeviye.Text = "ORTA SEVİYE";
                hakSayisi = 5;
                lblKalanHak.Text = hakSayisi.ToString();
            }
            else if (seviye == 3)
            {
                lblSeviye.Text = "ZOR SEVİYE";
                hakSayisi = 3;
                lblKalanHak.Text = hakSayisi.ToString();
            }
            else
            {
                MessageBox.Show("Böyle bir seviye bulunamadı!");
            }
        }

        private void btnBastanBasla_Click(object sender, EventArgs e)
        {
            // Herşeyi sıfırla ve baştan başlasın
            SeviyeyiAyarla(seviye);
            tahminSayisi = new Random().Next(0, 100);
            btnOnayla.Enabled = true;
            txtTahminSayisi.Text = "";
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            // Oyunucun hak sayısını kontrol et
            // Sayı 0 dan büyükse devam
            // sayı 0 a eşitse Kaybettin

            string tahminEdilenSayiString = txtTahminSayisi.Text;
            if (tahminEdilenSayiString == "")
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz");
            }
            else
            {
                if (hakSayisi == 0)
                {
                    btnOnayla.Enabled = false;
                    MessageBox.Show("KAYBETTİN HAKKIN BİTTİ");
                    return;
                }

                hakSayisi--;
                lblKalanHak.Text = hakSayisi.ToString();

                //  hakSayisi = hakSayisi - 1;


                int tahminEdilenSayi = int.Parse(tahminEdilenSayiString);

                if (tahminEdilenSayi > tahminSayisi)
                {
                    MessageBox.Show("Daha küçük bir sayı gir");
                }
                else if (tahminEdilenSayi < tahminSayisi)
                {
                    MessageBox.Show("Daha büyük bir sayı gir");
                }
                else if (tahminSayisi == tahminEdilenSayi)
                {
                    string kazandizMesaji = hakSayisi + " hak kala kazandınız!";
                    MessageBox.Show(kazandizMesaji);
                    btnOnayla.Enabled = false;
                }
            }
        }
    }
}
