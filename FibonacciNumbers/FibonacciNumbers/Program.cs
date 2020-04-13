using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fibonacci());
        }

        static long fibonacci()
        {
            //Step 1 - Base values
            long max = 4000000;
            long x = 1;
            long y = 2;
            long z;
            long even = 0;
            

            while (x < max || y < max)
            {
                z = x + y;
                x = y;
                y = z;

                if (x % 2 == 0)
                {
                    even = even + x;
                }
                if (y % 2 == 0)
                {
                    even = even + y;
                }
            }

            return even;

        }

    }
}
