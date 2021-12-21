using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            //Soru:Bir satış firmasında satış personellerinin maaşları taban ücret + prim şeklinde hesaplanmaktadır.Taban ücret ve satış miktarı sisteme dışarıdan girilecektir.
            //Prim hesaplaması ise satış miktarına göre hesaplanacaktır
            //20000 den az ise %1
            //20001-50000 arası %2
            //50001den büyükse %3 olarak hesaplanacakır.

            double tabanucret, prim=0 , satismiktari, maas;

            Console.WriteLine("Taban ucreti giriniz");
            tabanucret = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Satis miktarini giriniz");
            satismiktari = Convert.ToDouble(Console.ReadLine());


            if (satismiktari <= 20000)
            {
                prim = (satismiktari / 100);                
            }
            else if (satismiktari > 20000 && satismiktari <= 50000)
            {
                prim = (satismiktari * 2 / 100);                
            }           
            else if (satismiktari > 50000)
            {
                prim = (satismiktari * 3 / 100);                
            }

            Console.WriteLine("maas=" + (tabanucret + prim));

        }
    }
}
