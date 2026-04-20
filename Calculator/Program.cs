using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        static void Main()
        {
            Console.WriteLine("Enter Two Numbers:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
        Start:
            Console.WriteLine("Enter Operation: ");
            Console.WriteLine("1 Add, 2 Sub, 3 Multi, 4 division, 5 Remainder");
            int z = Convert.ToInt32(Console.ReadLine());

            if (z == 1)
            {
                Console.WriteLine((x + y));
                Console.ReadLine();
            }
            else if (z == 2)
            {
                Console.WriteLine((x - y));
                Console.ReadLine();
            }
            else if (z == 3)
            {
                Console.WriteLine((x * y));
                Console.ReadLine();
            }
            else if (z == 4)
            {
                Console.WriteLine((x / y));
                Console.ReadLine();
            }
            else if (z == 5)
            {
                Console.WriteLine((x % y));
                Console.ReadLine();
            }
            else if (z == 6) {                 Console.WriteLine("Exiting...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid Operation, Retry Again");
                goto Start;
            }
        }
    }
}
