using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {

            string kindOfYear = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            if (kindOfYear == "t")
            {
                Console.WriteLine("{0}", h + ((52 - h) * 2 * 1 / 3) + (p * 1 / 2) + 3);
            }
            else if (kindOfYear == "f")
            {
                Console.WriteLine("{0}", h + ((52 - h) * 2 * 1 / 3) + (p * 1 / 2));
            }

        }
    }
}
