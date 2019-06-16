using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maasHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maaş giriniz");
            int maas = 0;
            bool parsed = int.TryParse(Console.ReadLine(), out maas);
            Console.WriteLine("ürettiği ürün miktarını giriniz");
            int urun = 0;
            bool parsed2 = int.TryParse(Console.ReadLine(), out urun);
            //int net = 0;
            if (parsed && parsed2)
            {
                if (urun >= 1 && urun < 11)
                {
                    maas = maas + (urun * 5);
                    Console.WriteLine("İşçinin Alacağı Maaş " + maas + " TL'dir");
                }
                else if (urun >= 11 && urun < 26)
                {
                    maas = maas + (urun * 11);
                    Console.WriteLine("İşçinin Alacağı Maaş " + maas + " TL'dir");
                }
                else if (urun >= 26 && urun < 41)
                {
                    maas = maas + (urun * 17);
                    Console.WriteLine("İşçinin Alacağı Maaş " + maas + " TL'dir");
                }
                else if (urun > 40)
                {
                    maas = maas + (urun * 30);
                    Console.WriteLine("İşçinin Alacağı Maaş " + maas + " TL'dir");
                }
            }
            else
            {
                Console.WriteLine("Hatalı veri girişi !");
            }
            Console.ReadKey();
        }
    }
}
