using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] kurslar = new string[] { "Yazılım geliştirici" ,
                "Programlamaya giriş",
                "Java","python", "js", "kotlin", "swift"
            };


            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            foreach (string kurs  in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
