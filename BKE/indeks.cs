using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedenKitleEndeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beden kitle indeksi = Kilo / Boy * Boy
            // Beden kitle indeksi 18'e eşit veya küçükse ZAYIF
            // 18 ile 25 arasındaysa NORMAL
            // 25' den büyükse OBEZ yazdıran program parçasını kodlayın

            Console.WriteLine("Lütfen kilonuzu giriniz: ");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen boyunuzu giriniz: ");
            double boy = Convert.ToDouble(Console.ReadLine());

            double indeks = Convert.ToDouble(kilo / (boy * boy));

            if (indeks<=18)
            {
                Console.WriteLine(indeks);
                Console.WriteLine("ZAYIF");
            }
            else if (indeks>18 && indeks<25)
            {
                Console.WriteLine(indeks);
                Console.WriteLine("NORMAL");
            }
            else
            {
                Console.WriteLine(indeks);
                Console.WriteLine("OBEZ");
            }
            Console.ReadLine();
        }
    }
}
