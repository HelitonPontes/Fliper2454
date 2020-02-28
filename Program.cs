using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fliper2454
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] texto = Console.ReadLine().Split(' ');
            int N1 = int.Parse(texto[0]), N2 = int.Parse(texto[1]);

            if (N1 == 0)
            {
                Console.WriteLine("C");

            }
            else if (N1 == 1 && N2==0)
            {
                Console.WriteLine("B");
            }
            else if (N1 == 1 && N2 == 1)
            {
                Console.WriteLine("A");
            }

            Console.ReadKey();
        }
    }
}
