using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_WindowsFormElemanInceleme
{
    public class urun
    {
        public Guid id { get; set; }
        public string urunResimYol { get; set; }
        public string urunTanim { get; set; }
        public string urunKod { get; set; }
        public string urunRenk { get; set; }
        public string urunAciklama { get; set; }
        public string urunKategori { get; set; }
        public List<urunOzellikTanim> urunOzellikListe { get; set; }
        public bool ekGaranti { get; set; }

    }

    public class urunOzellikTanim
    {
        public Guid id { get; set; }
        public string Tanim { get; set; }

        public override string ToString()
        {
            return Tanim;
        }
    }
}
