using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritipleriyazilimkulubu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ders notunuzu giriniz");
            string a = Console.ReadLine();
            int sonuc = int.Parse(a);

            if (sonuc < 50)
            {
                Console.WriteLine("Bu dersten kaldınız");
            }

            else if (50 < sonuc)
            {
                Console.WriteLine("Bu dersten geçtiniz");

            }
            else
            {
                Console.WriteLine("Geçersiz not girişi yaptınız");
            }
            Console.ReadLine();
            /*
            // DegiskenTipi DegiskenAdi
            int bosdeger;
            bosdeger = 9;
            int sayi = 5;
            int b = 8;
            Console.WriteLine(sayi + b);
            Console.WriteLine("5+8" + "=" + (sayi + b));
            bool dogrumu;
            dogrumu = false;
            dogrumu = true;
            Console.WriteLine(dogrumu);
            string isim = "Kadir Can";
            string soyisim = "Kirkoyun";
            Console.WriteLine("İsmim" + " " + (isim + " " + soyisim));
            float f = 9.1f;
            double d = 0.9;
            byte e = 94;
            long r = 14343;
            short st = -3035;
            decimal yt = -5M;
            char ch = 'a';
            Console.ReadLine();
            */
        }
    }
}
