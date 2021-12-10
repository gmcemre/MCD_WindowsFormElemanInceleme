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
    public partial class sistemGiris : Form
    {
        public sistemGiris()
        {
            InitializeComponent();
        }

        private void btnGirisKontrol_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txtSifre.Text))
            {
                if (txtKullaniciAdi.Text == "admin" && txtSifre.Text == "1")
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Giriş Bilgileriniz Hatalı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtKullaniciAdi.Text = string.Empty;
                    txtSifre.Text = string.Empty;
                }

            }
            else
            {
                MessageBox.Show("Lütfen form alanlarını eksiksiz olarak doldurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
