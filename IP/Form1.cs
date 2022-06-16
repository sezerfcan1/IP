using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResimEkle_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.DefaultExt = ".jpg";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog.ShowDialog();
                String ResminYolu = openFileDialog.FileName;
                PictureBoxSol.Image = Image.FromFile(ResminYolu);
            }
            catch { }
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            KarsitlikButton.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            KarsitlikButton.Visible = false;
            TasimaButton.Visible = false;
            AynalamaButton.Visible = false;
            MeanFiltresiButton.Visible = false;
            MedyanFiltresi.Visible = false;
            EsiklemeButton.Visible = false;
            Utils.ResmiKaydet(picSol: PictureBoxSol, picSag: PictureBoxSag);
        }

        private void Negatif_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            KarsitlikButton.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            KarsitlikButton.Visible = false;
            TasimaButton.Visible = false;
            AynalamaButton.Visible = false;
            MeanFiltresiButton.Visible = false;
            MedyanFiltresi.Visible = false;
            EsiklemeButton.Visible = false;
            Bitmap img = Utils.NegatifAl((Bitmap)PictureBoxSol.Image);
            PictureBoxSag.Image = img;
            PictureBoxSag.Refresh();
        }

        private void Gri_Ton_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            KarsitlikButton.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            KarsitlikButton.Visible = false;
            TasimaButton.Visible = false;
            AynalamaButton.Visible = false;
            MeanFiltresiButton.Visible = false;
            MedyanFiltresi.Visible = false;
            EsiklemeButton.Visible = false;
            Bitmap img = Utils.GriTon((Bitmap)PictureBoxSol.Image);

            PictureBoxSag.Image = img;
            PictureBoxSag.Refresh();
        }

        private void Parlaklik_Arttır_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            KarsitlikButton.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            KarsitlikButton.Visible = false;
            TasimaButton.Visible = false;
            AynalamaButton.Visible = false;
            MeanFiltresiButton.Visible = false;
            MedyanFiltresi.Visible = false;
            EsiklemeButton.Visible = false;
            if (PictureBoxSag.Image != null)
            {
                Bitmap img = Utils.ParlaklikArttir((Bitmap)PictureBoxSag.Image);
                PictureBoxSag.Image.Dispose();
                PictureBoxSag.Image = img;
                PictureBoxSag.Refresh();
            }
            else
            {
                Bitmap img = Utils.ParlaklikArttir((Bitmap)PictureBoxSol.Image);

                PictureBoxSag.Image = img;
                PictureBoxSag.Refresh();
            }
        }

        private void Parlaklik_Azalt_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            KarsitlikButton.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            KarsitlikButton.Visible = false;
            TasimaButton.Visible = false;
            AynalamaButton.Visible = false;
            MeanFiltresiButton.Visible = false;
            MedyanFiltresi.Visible = false;
            EsiklemeButton.Visible = false;
            if (PictureBoxSag.Image != null)
            {
                Bitmap img = Utils.ParlaklikAzalt((Bitmap)PictureBoxSag.Image);
                PictureBoxSag.Image.Dispose();
                PictureBoxSag.Image = img;
                PictureBoxSag.Refresh();
            }
            else
            {
                Bitmap img = Utils.ParlaklikAzalt((Bitmap)PictureBoxSol.Image);

                PictureBoxSag.Image = img;
                PictureBoxSag.Refresh();
            }
        }

        private void Esikleme_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            EsiklemeButton.Visible = true;
        }

        private void Histogram_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;

            if (PictureBoxSag.Image != null)
            {
                Utils.Histogram((Bitmap)PictureBoxSag.Image,listBox1,PictureBoxSag);

            }
            else
            {
                Utils.Histogram((Bitmap)PictureBoxSol.Image, listBox1, PictureBoxSag);

            }
        }

        private void EsiklemeButton_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            KarsitlikButton.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            KarsitlikButton.Visible = false;
            TasimaButton.Visible = false;
            AynalamaButton.Visible = false;
            MeanFiltresiButton.Visible = false;
            MedyanFiltresi.Visible = false;
            EsiklemeButton.Visible = false;
            EsiklemeButton.Visible = false;

            if (PictureBoxSag.Image != null)
            {

                Bitmap img = Utils.Esikleme((Bitmap)PictureBoxSag.Image, Convert.ToInt32(textBox1.Text));
                PictureBoxSag.Image.Dispose();
                PictureBoxSag.Image = img;
                PictureBoxSag.Refresh();
            }
            else
            {
                Bitmap img = Utils.Esikleme((Bitmap)PictureBoxSol.Image, Convert.ToInt32(textBox1.Text));

                PictureBoxSag.Image = img;
                PictureBoxSag.Refresh();
            }
        }

        private void Karsitlik_Click(object sender, EventArgs e)
        {
            KarsitlikButton.Visible = true;
            textBox1.Visible = true;
            label1.Visible = true;


        }

        private void KarsitlikButton_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            KarsitlikButton.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            KarsitlikButton.Visible = false;
            TasimaButton.Visible = false;
            AynalamaButton.Visible = false;
            MeanFiltresiButton.Visible = false;
            MedyanFiltresi.Visible = false;
            EsiklemeButton.Visible = false;

            if (PictureBoxSag.Image != null)
            {
                Bitmap img = Utils.Karsitlik((Bitmap)PictureBoxSag.Image, Convert.ToInt32(textBox1.Text));
                PictureBoxSag.Image.Dispose();
                PictureBoxSag.Image = img;
                PictureBoxSag.Refresh();
            }
            else
            {
                Bitmap img = Utils.Karsitlik((Bitmap)PictureBoxSol.Image, Convert.ToInt32(textBox1.Text));

                PictureBoxSag.Image = img;
                PictureBoxSag.Refresh();
            }
        }

        private void Tasima_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            TasimaButton.Visible = true;
        }

        private void TasimaButton_Click(object sender, EventArgs e)
        {
            PictureBoxSag.Image = Utils.Tasima((Bitmap)PictureBoxSol.Image, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            listBox1.Visible = false;
            KarsitlikButton.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            KarsitlikButton.Visible = false;
            TasimaButton.Visible = false;
            AynalamaButton.Visible = false;
            MeanFiltresiButton.Visible = false;
            MedyanFiltresi.Visible = false;
            EsiklemeButton.Visible = false;
        }

        private void Aynalama_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
            AynalamaButton.Visible = true;
        }

        private void AynalamaButton_Click(object sender, EventArgs e)
        {
            PictureBoxSag.Image = Utils.Aynalama((Bitmap)PictureBoxSol.Image, Convert.ToInt32(textBox1.Text));
            listBox1.Visible = false;
            KarsitlikButton.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            KarsitlikButton.Visible = false;
            TasimaButton.Visible = false;
            AynalamaButton.Visible = false;
            MeanFiltresiButton.Visible = false;
            MedyanFiltresi.Visible = false;
            EsiklemeButton.Visible = false;
        }

        private void MeanFiltresi_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
            MeanFiltresiButton.Visible = true;
        }

        private void MeanFiltresiButton_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            KarsitlikButton.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            KarsitlikButton.Visible = false;
            TasimaButton.Visible = false;
            AynalamaButton.Visible = false;
            MeanFiltresiButton.Visible = false;
            MedyanFiltresi.Visible = false;
            EsiklemeButton.Visible = false;
            PictureBoxSag.Image = Utils.MeanFiltre((Bitmap)PictureBoxSol.Image, Convert.ToInt32(textBox1.Text));
        }

        private void Medyan_Filtresi_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
            MedyanFiltresi.Visible = true;
        }

        private void MedyannFiltresi_Button_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            KarsitlikButton.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            KarsitlikButton.Visible = false;
            TasimaButton.Visible = false;
            AynalamaButton.Visible = false;
            MeanFiltresiButton.Visible = false;
            MedyanFiltresi.Visible = false;
            EsiklemeButton.Visible = false;
            PictureBoxSag.Image = Utils.MedyanFiltre((Bitmap)PictureBoxSol.Image, Convert.ToInt32(textBox1.Text));
        }

        private void GausFiltresiClick(object sender, EventArgs e)
        {
            PictureBoxSag.Image = Utils.Gaus((Bitmap)PictureBoxSol.Image);
        }

        private void xYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBoxSag.Image = Utils.Sobel((Bitmap)PictureBoxSol.Image , 1);
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBoxSag.Image = Utils.Sobel((Bitmap)PictureBoxSol.Image, 2);
        }

        private void yToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBoxSag.Image = Utils.Sobel((Bitmap)PictureBoxSol.Image, 3);
        }

        private void prewittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBoxSag.Image = Utils.Prewitt((Bitmap)PictureBoxSol.Image);
        }

        private void robertCrossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBoxSag.Image = Utils.RobertCross((Bitmap)PictureBoxSol.Image);

        }
    }
}
