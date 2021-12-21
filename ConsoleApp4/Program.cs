using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sart ifadeleri/ Karar Mekanizmaları
            //1)İF-ELSE,2)SWİTCH-CASE
            //Kötü
            //int sayi = int.Parse(Console.ReadLine());
            //if (sayi > 10)
            //{
            //    Console.WriteLine("sayi 10'dan buyuk");
            //    Console.WriteLine("...");
            //}
            //şekilli paranteze alarak 2 kodu da şarta bağladık...
            //if (sayi < 10)
            //    Console.WriteLine("Sayi 10'dan kucuk");
            //if (sayi == 10)
            //    Console.WriteLine("sayi 10'a eşit");
            //profesyonel bir yazış biçimi değil.Daha az satırda yazabilirsin.İf-else'i aynı anda kullan...


            //İyi bir kullanım!!!
            int sayi = int.Parse(Console.ReadLine());
            if (sayi > 10)
            {
                Console.WriteLine("Sayi 10'dan büyük");
            }
            else if (sayi < 10)
            {
                Console.WriteLine("Sayi 10'dan küçük");
            }
            else
                Console.WriteLine("Sayi 10'a eşit");
            

                    
                    
                 
        }
    }
}
