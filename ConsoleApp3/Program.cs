using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru:Kullanıcı tarafından girilen 2 tamsayıyı toplayıp ekrana yazan programı yazınız.

            int sayi1, sayi2, toplam;
            Console.WriteLine("Birinci Sayıyı Giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Giriniz");
            sayi2 = int.Parse(Console.ReadLine());

            //toplam = sayi1 + sayi2;
            //Console.WriteLine(toplam);
            //Console.WriteLine(sayi1 + sayi2);
            //Console.WriteLine("Toplam=" + (sayi1+sayi2));
            Console.WriteLine("Toplam={0}" ,sayi1 + sayi2);
            Console.WriteLine($"Sayıların Toplamı={sayi1+sayi2}");
            Console.WriteLine($"Sonuç={sayi1 + sayi2}");





        }
    }
}
