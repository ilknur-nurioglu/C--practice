using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanVeriAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıdan 3 adet not bilgisi alan ve bu notların ortalamasına
            // göre eğer ortalama 80 - 100 arasındaysa A+
            // 60-80 arasındaysa A
            // 40-60 arasındaysa B+
            // 40'dan küçükse F yazdırın

            Console.WriteLine("Lütfen 1.notunuzu giriniz: ");
            int not1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2.notunuzu giriniz:  ");
            int not2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 3.notunuzu giriniz:  ");
            int not3 = Convert.ToInt32(Console.ReadLine());

            int ortalama = (not1+ not2 + not3) / 3;
            Console.WriteLine("Not Ortalamanız: "+ortalama);

            if (ortalama>80 && ortalama<100)
            {
                Console.WriteLine("A+");
            }
            else if (ortalama>60 && ortalama<80)
            {
                Console.WriteLine("A");
            }
            else if (ortalama>40 && ortalama<60 )
            {
                Console.WriteLine("B+");
            }
            else if (ortalama<40)
            {
                Console.WriteLine("F");
            }
            Console.ReadLine();
        }
    }
}
