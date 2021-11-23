using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int hak = 3;
            while (true)
            {
                Console.WriteLine("kullananıcı adınızı giriniz");
                String kullaniciAdi = Console.ReadLine();

                Console.WriteLine("şifrenizi giriniz");
                string sifre = Console.ReadLine();
                if (kullaniciAdi == "enes" && sifre == "123")
                {
                    Console.WriteLine("tebrikler giriş yaptınız");
                    break;
                }
                else
                {
                    Console.WriteLine("yanlış şifre ya da yanlış kullanıcı adı girdiniz");
                    if (hak > 0)
                    {
                        hak = hak - 1;
                    }
                    if (hak == 0)
                    {
                        Console.WriteLine("Hakkınız dolmuştur");
                        break;
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
