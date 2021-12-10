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

            //check box Listeleme
            //selectedItem: 1 ürün bilgisi getirir özel tiplerde kullanılır.
            //selectedText: özel bir tip kullanıyorsanız bir ürün seçimi dahi olsa selected text kısmında ayarlamış olduğumuz değeri yakalarız.
            //selectedValue: kısmında ise text kısmında olduğu gibi value kısmında görmek istediğimiz değeri yakalarız.

            foreach (object item in cltUrunOzellikleri.CheckedItems)
            {
                //Kısa kod yazımı 
                //kayitUrun.urunOzellikListe.Add((urunOzellikTanim)item);

                //Uzun kod yazımı
                urunOzellikTanim Temp = (urunOzellikTanim)item;
                kayitUrun.urunOzellikListe.Add(Temp);
                //bu kısımda InnerType olarak kulandığımız List generic eğer yapıcı metot ile örneklenmediyse null ref hatası alırısınız...
                //Bunu çözmek için ctor(urun) metot içinde List<T> koleksiyonu örneklemeniz gereklidir.
            }
        }
    }
}
