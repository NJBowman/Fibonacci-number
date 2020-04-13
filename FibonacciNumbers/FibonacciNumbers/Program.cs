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

            //even is set to start as 2 to take on the first even value from y
            long even = 2;
            

            while (x < max || y < max)
            {
                z = x + y;
                x = y;
                y = z;
                

                if (z % 2 == 0)
                {
                    even += z;
                    Console.WriteLine(even);
                }
                
            }


            return even;
        }

    }
}
