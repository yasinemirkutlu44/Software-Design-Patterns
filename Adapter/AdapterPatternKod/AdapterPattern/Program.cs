using System;
using System.Linq;

namespace AdapterPattern
{
     class Program
    {
        public static void Main(string[] args)
        {
            Hedef adapter = new Adapter();
            Hedef adapter2 = new Adapter();
            Hedef adapter3 = new Adapter();

            Console.WriteLine("-----ÖĞRENCİ DURUM BİLGİLERİ-----");
            foreach(string student in adapter.StudentsFetch())
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("-----ÖĞRENCİ GNO BİLGİLERİ-----");
            foreach (string gpa in adapter2.GPAFetch())
            {
                Console.WriteLine(gpa);
            }

            Console.WriteLine("-----ÖĞRENCİ CİNSİYET BİLGİLERİ-----");
            foreach (string gender in adapter3.Gender())
            {
                Console.WriteLine(gender);
            }

        }
    }
}
