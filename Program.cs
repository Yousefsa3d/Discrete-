using System;

namespace prime_numbers2
{
    class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {

            int num, i, flag, n1, n2;
            Console.WriteLine("Enter first number ");

            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number ");

            n2 = int.Parse(Console.ReadLine());
            num = n1;
            Console.WriteLine("      \n  Prime Numbers                   ");

            while (num <= n2)
            {
                flag = 0;
                for (i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)

                    Console.WriteLine(num);
                num++;
            }
            Console.ReadKey();
        }
    }
}
