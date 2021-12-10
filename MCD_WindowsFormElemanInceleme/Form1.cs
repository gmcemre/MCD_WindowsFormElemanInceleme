using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_WindowsFormElemanInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void sistemGirisForm()
        {
            sistemGiris sistemGirisForm = new sistemGiris();
            sistemGirisForm.ShowDialog();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            sistemGirisForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormElemanlariDoldur();
        }

        private void FormElemanlariDoldur()
        {
            cltUrunOzellikleri.Items.AddRange(Helper.urunOzellikListe.ToArray());

            //comboBox değer atama -1
            cmbUrunKategori.Items.AddRange(Helper.kategoriListe.ToArray());

            //comboBox değer atama -2
            cmbUrunRenk.Items.AddRange(Helper.urunRenk.ToArray());
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            DialogResult resault = OFD.ShowDialog();

            if (resault == DialogResult.OK)
            {
                pctUrunResim.Image = Image.FromFile(OFD.FileName);
                pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            urun kayitUrun = new urun();

            kayitUrun.id = Guid.NewGuid();

            //Open File Dialog data alma işlemi...
            if (!string.IsNullOrEmpty(OFD.FileName))
            {
                kayitUrun.urunResimYol = OFD.FileName;
            }

            //TextBox tan değer alma işlemi...
            if (!string.IsNullOrEmpty(txtUrunTanim.Text))
            {
                kayitUrun.urunTanim = txtUrunTanim.Text;
            }

            if (!string.IsNullOrEmpty(txtUrunKod.Text))
            {
                kayitUrun.urunKod = txtUrunKod.Text;
            }

            //ComboBox tan seçilen datayı almak
            kayitUrun.urunRenk = cmbUrunRenk.SelectedItem.ToString();

            kayitUrun.urunKategori = cmbUrunKategori.SelectedItem.ToString();

            //RichText
            kayitUrun.urunAciklama = txtAciklama.Text;

        }
    }
}
