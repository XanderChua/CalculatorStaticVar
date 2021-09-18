using System;

namespace CalculatorStaticVar
{
    class Program
    {
        class Cal {

            public static int count = 0;
            /*static Cal()
            {
                count = 0;
            }*/

            public int add(int x, int y)
            {
                count++;
                int z = x + y;
                return z;
            }

            public int min(int x, int y)
            {
                count++;
                int z = x - y;
                return z;
            }

            public int x(int x, int y)
            {
                count++;
                int z = x * y;
                return z;
            }

            public int div(int x, int y)
            {
                count++;
                int z = x / y;
                return z;
            }
            static void Main(string[] args)
            {
                Cal calculator = new Cal();
                Console.WriteLine(calculator.add(10,5));
                Console.WriteLine(calculator.add(10, 6));               

                Console.WriteLine(calculator.min(6, 3));
                
                Console.WriteLine(calculator.x(2, 3));

                Console.WriteLine(calculator.div(10, 2));

                Console.WriteLine("Total count: " + Cal.count);
            }
        }
    }
}
