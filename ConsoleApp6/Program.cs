using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru:2. dereceden verilen bir denklemin kök durumlarını inceleyen programı yazınız...
            int a, b, c, delta;
            Console.WriteLine("a sayısını giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b sayısını giriniz");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c sayısını giriniz");
            c = Convert.ToInt32(Console.ReadLine());

            
            delta = b * b - (4 * a * c);
            Console.WriteLine("delta={0}",delta);
            if (delta>0)
                Console.WriteLine("Reel iki kök var");
            else if (delta==0)
                Console.WriteLine("Çakışık iki kök var");
            else
                Console.WriteLine("Reel kök yok");
        }
    }
}
