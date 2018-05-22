using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 1.0f;

            while (x <= 100)
            {
                // If the remainder of x/3 and x/5 is 0 (i.e. is divisible by 3 and 5) the console prints "FizzBuzz"
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                // If the remainder of x/3 is 0 (i.e. is divisible by 3) the console prints "Fizz"
                else if (x % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                // If the remainder of x/5 is 0 (i.e. is divisible by 5) the console prints "Buzz"
                else if (x % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                // If none of the conditions are met (i.e. not divisible by 3 and/or 5) the console prints the number
                else
                {
                    Console.WriteLine(x);
                }

                x = x + 1; // x is increased by 1 and the code reruns
            }

            Console.ReadKey();
        }
    }
}
