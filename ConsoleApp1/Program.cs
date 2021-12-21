using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru:Yarıçapı girilen bir dairenin alanını ve çevresini hesaplayıp sonucu ekrana yazan programı yazınız...
            //double r, pi=3.14;
            //Console.WriteLine("Yarıçapı Giriniz");
            //r = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Alan=" + (pi * r * r));
            //Console.WriteLine("Çevre=" + (2 * pi * r));
            double r;
            Console.WriteLine("Yarıçapı Giriniz");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("Alan={0}", (Math.PI*r*r));
            Console.WriteLine("Çevre={0}", (2*Math.PI*r));

            //Write,writeline
            Console.Write("Merhaba \n\n\t deneme \b");
            Console.Write("Dünya");
            //path bilgisi
            //Console.WriteLine("c:\a\b\c\dosya.dat");
            Console.WriteLine("c:a\\b\\c\\dosya.dat");
            Console.WriteLine("c:a/b/c/dosya.dat");
            Console.WriteLine(@"c:a/b/c/dosya.dat");


        }
    }
}
