using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch-case

            int gün = int.Parse(Console.ReadLine());
            switch (gün)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                break;
                case 2:
                    Console.WriteLine("Salı");
                break;
                case 3:
                    Console.WriteLine("Çarşamba");
                break;
                case 4:
                    Console.WriteLine("Perşembe");
                break;
                case 5:
                    Console.WriteLine("Cuma");
                break;
                case 6:
                case 7:
                    Console.WriteLine("Haftasonu");
                break;
                default:
                    Console.WriteLine("1 ile 7 arasında değer giriniz");
                break;
            }
        }
    }
}
