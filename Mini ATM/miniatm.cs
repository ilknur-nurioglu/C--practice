using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yapılacak işlem sorulur
            // 1 bakiye görüntüleme
            // 2 para çekme
            // 3 para yatırma
            // q çıkış

            int bakiye = 1000;
            Console.WriteLine("1- Bakiye Görüntüleme");
            Console.WriteLine("2- Para Çekme");
            Console.WriteLine("3- Para Yatırma");
            Console.WriteLine("q - Çıkış");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi tuşlayınız: ");
            string secim = Console.ReadLine();

            if (secim=="1")
            {
                Console.WriteLine("Bakiyeniz: "+bakiye);
                Console.ReadLine();
            }
            else if (secim=="2")
            {
                Console.WriteLine("Lütfen çekmek istediğiniz tutarı giriniz: ");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                if (cekilecek_tutar<=bakiye)
                {
                    Console.WriteLine("Güncel bakiyeniz: "+ (bakiye-cekilecek_tutar));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Çekmek istediğiniz tutar bakiyenizden fazla olamaz !");
                    Console.ReadLine();
                }
            }
            else if (secim == "3")
            {
                Console.WriteLine("Lütfen yatırmak istediğiniz tutarı giriniz: ");
                int yatirilan_tutar = Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("Güncel bakiyeniz: "+(bakiye+yatirilan_tutar));
                Console.ReadLine();
            }
            else if (secim=="q")
            {
                Console.WriteLine("Çıkış yapılıyor...");
                Console.ReadLine();
            }
            
        }
    }
}
