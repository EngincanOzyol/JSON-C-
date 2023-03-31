using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class Personel
    {
        public Guid id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string sehir { get; set; }
        public string email { get; set; }
        public string telno { get; set; }
    }
}
