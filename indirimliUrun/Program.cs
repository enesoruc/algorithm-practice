using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indirimliUrun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Fiyatı Giriniz");
            int fiyat1 = 0;
            bool isParsed = int.TryParse(Console.ReadLine(), out fiyat1);
            Console.WriteLine("2. Fiyatı Giriniz");
            int fiyat2 = 0;
            bool isParsed2 = int.TryParse(Console.ReadLine(), out fiyat2);
            int sonfiyat = fiyat1 + fiyat2;
            int odeme = sonfiyat;


            if (isParsed && isParsed2)
            {
                if (sonfiyat >= 200)
                {


                    odeme = sonfiyat - ((fiyat2 * 25) / 100);
                    Console.WriteLine("Ödenecek rakam:" + odeme + " TL dir");
                }
                else
                {
                    Console.WriteLine("Ödenecek rakam:" + (sonfiyat) + " TL dir");
                }
            }
            else
            {
                Console.WriteLine("Hatalı sayı girişi. Lütfen tekrar deneyiniz");
            }




            Console.ReadKey();
        }
    }
}
