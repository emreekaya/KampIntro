using System;

namespace classıntro
{
    class Program
    {
        static void Main(string[] args)
        {

            kurs kurs1 = new kurs();
            kurs1.Egitmeni = "engin demiroğ";
            kurs1.KursAdi = "c#";
            kurs1.IzlenmeOrani = 30;


            kurs kurs2 = new kurs();
            kurs2.Egitmeni = "kadir";
            kurs2.KursAdi = "python";
            kurs2.IzlenmeOrani = 60;


            kurs kurs3 = new kurs();
            kurs3.Egitmeni = "emre";
            kurs3.KursAdi = "java";
            kurs3.IzlenmeOrani = 90;

           
            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.Egitmeni);

            }

            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmeni + " "+ kurs1.IzlenmeOrani);
            Console.WriteLine(kurs2.KursAdi + " " + kurs2.Egitmeni + " " + kurs2.IzlenmeOrani);
            Console.WriteLine(kurs3.KursAdi + " " + kurs3.Egitmeni + " " + kurs3.IzlenmeOrani);
        }
    }
    class kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
