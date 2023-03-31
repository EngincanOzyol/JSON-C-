using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personel> list = new List<Personel>();
            for (int i = 0; i < 1000; i++)
            {
                Personel p1 = new Personel();
                p1.id=Guid.NewGuid();
                p1.isim = FakeData.NameData.GetFirstName();
                p1.soyisim = FakeData.NameData.GetSurname();
                p1.email=$"{p1.isim}.{p1.soyisim}@{FakeData.NetworkData.GetDomain()}";
                p1.telno=FakeData.PhoneNumberData.GetPhoneNumber();
                list.Add(p1);
            }
            if (Directory.Exists("c:\\JSONKlasörüm\\")) { }
            else { Directory.CreateDirectory("c:\\JSONKlasörüm\\"); }
            string jsonPersonellerim=Newtonsoft.Json.JsonConvert.SerializeObject(list);
            File.WriteAllText("c:\\JSONKlasörüm\\personel.json", jsonPersonellerim);
            
        }
    }
}
