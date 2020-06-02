using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Adaptee
    {
        public List<string> OgrenciListeGetir()
        {
            List<string> OgrenciListe = new List<string>();
            OgrenciListe.Add("Başvuru yapan 1.Öğrencinin Adı:\n Ahmet Yıldız \n Ögrenci No: 648723 \n Dogum Yeri : Istanbul \n Yabancı Diller : Ingilizce, Rusça \n Programlama Dilleri : Java, C# \n Okuduğu bölüm : Yazılım Mühendislği");
            OgrenciListe.Add("Başvuru yapan 2.Öğrencinin Adı:\n Ayşe Sumer \n Ögrenci No: 354751 \n Dogum Yeri: Ankara \n Yabancı Diller: Almanca, İngilizce \n Programlama Dilleri: C++, C#, Pyhton \n Okuduğu bölüm : Bilgisayar Mühendislği");
            OgrenciListe.Add("Başvuru yapan 3.Öğrencinin Adı:\n Ali Yerli \n Ögrenci No: 734781 \n Dogum Yeri: Izmir \n Yabancı Diller: Almanca, İngilizce, Japonca \n Programlama Dilleri: Pyhton \n Okuduğu bölüm: Endüstri Mühendislği");
            OgrenciListe.Add("Başvuru yapan 4.Öğrencinin Adı:\n Busra Ocak \n Ögrenci No: 397472 \n Dogum Yeri: Kocaeli \n Yabancı Diller: Fransızca, İngilizce \n Programlama Dilleri: C++, C#, Pyhton, Java \n Okuduğu bölüm : Bilgisayar Mühendislği");
            OgrenciListe.Add("Başvuru yapan 5.Öğrencinin Adı:\n İbrahim Tepe \n Ögrenci No: 193684 \n Dogum Yeri: Antalya \n Yabancı Diller: Çince, İngilizce, Arapça \n Programlama Dilleri: C++, C#, Pyhton, C, Javascript \n Okuduğu bölüm : Bilişim Sistemleri Mühendislği");
            return OgrenciListe;
        }

        public List<string> OgrenciGNOGetir()
        {
            List<string> OgrenciGNO = new List<string>();
            OgrenciGNO.Add("1. öğrenci GNO : 2.5");
            OgrenciGNO.Add("2. öğrenci GNO : 3.2");
            OgrenciGNO.Add("3. öğrenci GNO : 1.85");
            OgrenciGNO.Add("4. öğrenci GNO : 2.2");
            OgrenciGNO.Add("5. öğrenci GNO : 3.7");
            return OgrenciGNO;

        }

        public List<string> OgrenciCinsiyetGetir()
        {
            List<string> OgrenciCinsiyet = new List<string>();
            OgrenciCinsiyet.Add("1. öğrenci Cinsiyet : E");
            OgrenciCinsiyet.Add("2. öğrenci Cinsiyet : K");
            OgrenciCinsiyet.Add("3. öğrenci Cinsiyet : E");
            OgrenciCinsiyet.Add("4. öğrenci Cinsiyet : K");
            OgrenciCinsiyet.Add("5. öğrenci Cinsiyet : E");
            return OgrenciCinsiyet;

        }

    }
}
