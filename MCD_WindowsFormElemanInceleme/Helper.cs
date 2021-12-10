using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_WindowsFormElemanInceleme
{
    public static class Helper
    {
        public static List<urunOzellikTanim> urunOzellikListe = new List<urunOzellikTanim>
        {
            new urunOzellikTanim (){id=Guid .NewGuid (),Tanim="Pamuk" },
            new urunOzellikTanim(){id=Guid.NewGuid(),Tanim="Yıpranmaz" },
            new urunOzellikTanim(){id=Guid.NewGuid(),Tanim="%100  Yerli" },
            new urunOzellikTanim(){id = Guid.NewGuid(),Tanim = "Unısex" },
        };

        public static List<string> urunRenk = new List<string>
        {
            "Mavi","Siyah","Kırmızı","Beyaz","Pembe"
        };

        public static List<string> kategoriListe = new List<string>
        {
            "A Kategori","B Kategori","C Kategori"
        };

        public static List<urun> urunListeDB;

        static Helper()
        {
            urunListeDB = new List<urun>();
        }
    }
}
