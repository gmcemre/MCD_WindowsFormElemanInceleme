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
    }
}
