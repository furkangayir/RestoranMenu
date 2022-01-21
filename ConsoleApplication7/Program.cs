using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            double secim,adet,toplam=0;
            double hesap = 0;
            Console.WriteLine("1-Süt 2 TL 2-Çikolata 1 TL 3-Su 1 TL");
            Console.WriteLine("");
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("Hangi üründen istersiniz?");
                secim = Convert.ToDouble(Console.ReadLine());
                if (secim == 1)
                {
                    Console.WriteLine("Kaç tane süt?");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 2;
                    hesap = hesap + toplam;
                }
                else if (secim == 2)
                {
                    Console.WriteLine("Kaç adet çikolata?");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 1;
                    hesap = hesap + toplam;
                }
                else if (secim == 3)
                {
                    Console.Write("Kaç adet su?");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 1;
                    hesap = hesap + toplam;
                }
                else
                    Console.WriteLine("Böyle bir seçim yok");


            }
            Console.WriteLine("Toplam tutar" + hesap);
        }
    }
}
