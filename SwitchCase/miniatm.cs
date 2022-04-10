using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yapılacak işlem sorulur
            // 1 bakiye görüntüleme
            // 2 para çekme
            // 3 para yatırma
            // 4 çıkış
            // Hiçbiri değilse geçerli bir değer girilmesi istenir

            int bakiye = 1000;
            Console.WriteLine("1- Bakiye Görüntüleme");
            Console.WriteLine("2- Para Çekme");
            Console.WriteLine("3- Para Yatırma");
            Console.WriteLine("4 - Çıkış");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi tuşlayınız: ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz: "+ bakiye);
                    break;

                case "2":
                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz:");
                    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                    if (cekilecek_tutar<bakiye)
                    {
                        Console.WriteLine("Güncel Bakiyeniz: "+ (bakiye-cekilecek_tutar));
                    }
                    else
                    {
                        Console.WriteLine("Çekmek istediğiniz tutar bakiyenizden fazla !");
                    }
                    break;

                case "3":
                    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz: ");
                    int yatirilan_tutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Güncel Bakiyeniz: "+ (bakiye+yatirilan_tutar));
                    break;

                case "4":
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;

                default:
                    Console.WriteLine("Lütfen geçerli bir tuşlama yapınız.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
