using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");
            string Ad = Console.ReadLine();
            Console.WriteLine(Ad);
            int yas;
            //yas =int.Parse(Console.ReadLine());
            //64ten daha düşük bir bite çevirirken hata verir.her zaman küçükten büyüğe çevir.
            yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(yas);           

        }
    }
}
