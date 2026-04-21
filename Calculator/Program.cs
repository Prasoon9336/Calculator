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
            Console.WriteLine("1 Add, 2 Sub, 3 Multi, 4 division, 5 Remainder, 6 Increment Both Values, 7 Decrement Both Values");
            int z = Convert.ToInt32(Console.ReadLine());


            /* Two ways to calculate one comment out other is implemented to avoid confusion 
             * and 
             * to show both ways of doing the same thing
             * 
             * 
             * 1st way is using if else statement
             *
             * if (z == 1)
             * {
             * Console.WriteLine((x + y));
             * Console.ReadLine();
             * }
             * else if (z == 2)
             * {
             * Console.WriteLine((x - y));
             * Console.ReadLine();
             * }
             * else if (z == 3)
             * {
             * Console.WriteLine((x * y));
             * Console.ReadLine();
             * }
             * else if (z == 4)
             * {
             * Console.WriteLine((x / y));
             * Console.ReadLine();
             * }
             * else if (z == 5)
             * {
             * Console.WriteLine((x % y));
             * Console.ReadLine();
             * }
             * else if (z == 6)
             * {
             * Console.WriteLine((++x, ++y));
             * }
             * else if (z == 7)
             * {
             * Console.WriteLine((--x, --y));
             * }
             *
             */


            // 2nd way is using switch statement

            switch (z)
            {
                case 1:
                    Console.WriteLine((x + y));
                    break;
                case 2:
                    Console.WriteLine((x - y));
                    break;
                case 3:
                    Console.WriteLine((x * y));
                    break;
                case 4:
                    Console.WriteLine((x / y));
                    break;
                case 5:
                    Console.WriteLine((x % y));
                    break;
                case 6:
                    Console.WriteLine((++x, ++y));
                    break;
                case 7:
                    Console.WriteLine((--x, --y));
                    break;
                default:
                    Console.WriteLine("Invalid Operation, Retry Again");
                    goto Start;
            }
        }
    }
}
