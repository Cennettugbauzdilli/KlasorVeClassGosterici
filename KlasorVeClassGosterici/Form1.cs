using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlasorVeClassGosterici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKlasorSec_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear(); // Eski verileri temizle
                    string secilenKlasor = fbd.SelectedPath; // Seçilen klasörün yolu
                    KlasorVeClasslariListele(secilenKlasor); // Alt klasörleri ve class'ları listele
                }
            }
        }


        private void KlasorVeClasslariListele(string rootPath)
        {
            // 1. Adım: Ana klasördeki alt klasörleri bul
            string[] klasorler = Directory.GetDirectories(rootPath);

            foreach (string klasor in klasorler)
            {
                // Klasör adını al (yol değil, sadece ismi)
                string klasorIsmi = Path.GetFileName(klasor);

                // ListBox'a klasör adını ekle
                listBox1.Items.Add("📁 " + klasorIsmi);

                // 2. Adım: Klasör içindeki .cs dosyalarını bul
                string[] csDosyalari = Directory.GetFiles(klasor, "*.cs");

                foreach (string csDosya in csDosyalari)
                {
                    // Dosyayı satır satır oku
                    string[] satirlar = File.ReadAllLines(csDosya);

                    foreach (string satir in satirlar)
                    {
                        // Eğer satırda "class" kelimesi geçiyorsa
                        if (satir.Trim().StartsWith("class "))
                        {
                            // class ismini çek
                            string classIsmi = satir.Trim().Split(' ')[1];

                            // ListBox'a class ismini ekle (biraz girintili)
                            listBox1.Items.Add("   📄 " + classIsmi);
                        }
                    }
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var odemeSiniflari = typeof(IOdemeYontemi).Assembly.GetTypes()
        .Where(t => typeof(IOdemeYontemi).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

            foreach (var sinif in odemeSiniflari)
            {
                cmbOdemeYontemi.Items.Add(sinif.Name);
            }
        }


        private void cmbOdemeYontemi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            if (cmbOdemeYontemi.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçiniz.");
                return;
            }

            if (!decimal.TryParse(txtTutar.Text, out decimal tutar))
            {
                MessageBox.Show("Geçerli bir tutar giriniz.");
                return;
            }

            string secilenSinif = cmbOdemeYontemi.SelectedItem.ToString();

            var odemeTipi = typeof(IOdemeYontemi).Assembly.GetTypes()
                .FirstOrDefault(t => t.Name == secilenSinif);

            if (odemeTipi != null)
            {
                var odemeNesnesi = (IOdemeYontemi)Activator.CreateInstance(odemeTipi);
                string sonuc = odemeNesnesi.Ode(tutar);
                lblSonuc.Text = "Sonuç: " + sonuc;
            }
        }

        private void btnAciklamaGoster_Click(object sender, EventArgs e)
        {
            if (cmbOdemeYontemi.SelectedItem == null)
            {
                MessageBox.Show("Önce bir ödeme yöntemi seçiniz.");
                return;
            }

            string secilenSinif = cmbOdemeYontemi.SelectedItem.ToString();

            var odemeTipi = typeof(IOdemeYontemi).Assembly.GetTypes()
                .FirstOrDefault(t => t.Name == secilenSinif);

            if (odemeTipi != null)
            {
                var aciklamaAttr = (AciklamaAttribute)Attribute.GetCustomAttribute(odemeTipi, typeof(AciklamaAttribute));

                if (aciklamaAttr != null)
                {
                    lblAciklama.Text = "Açıklama: " + aciklamaAttr.Mesaj;
                }
                else
                {
                    lblAciklama.Text = "Açıklama bulunamadı.";
                }

            }
        }
    }
}
