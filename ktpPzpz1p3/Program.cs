using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktpPzpz1p3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 4 == 0 && n % 6 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 4 i sa 6.");
            }
            else if (n % 4 == 0)
            {
                Console.WriteLine("Broj je djeljiv s 4.");
            }
            else if (n % 6 == 0)
            {
                Console.WriteLine("Broj je djeljiv s 6.");
            }
            else
            {
                Console.WriteLine("Broj nije djeljiv sa 4 ni sa 6.");
            }
            Console.ReadKey();
        }
    }
}
