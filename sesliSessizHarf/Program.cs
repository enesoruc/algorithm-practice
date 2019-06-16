using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sesliSessizHarf
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int harf = rnd.Next(97, 123);
            char karakter = Convert.ToChar(harf);
            Console.WriteLine("Üretilen harf \" " + karakter + " \"");

            switch (karakter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                    Console.WriteLine("Üretilen harf sesli bir harf");

                    break;
                default:
                    Console.WriteLine("Üretilen harf sessiz bir harf");
                    break;
            }



            Console.ReadKey();
        }
    }
}
