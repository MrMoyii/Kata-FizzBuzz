using System;

namespace Kata_FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kata_FizzBuzz();
            Console.ReadKey();
        }
        public static string[] Kata_FizzBuzz()
        {
            string[] result = new string[100];

            for (int i = 0; i < 100; i++)
            {
                int n = i + 1;
                if (n % 3 == 0 && n % 5 == 0) result[i] = "FizzBuzz";
                else if (n % 3 == 0) result[i] = "Fizz";
                else if (n % 5 == 0) result[i] = "Buzz";
                else result[i] = n.ToString();

                Console.WriteLine(result[i]);
            }

            return result;
        }
    }
}
