using System;
using System.Collections.Generic;
using System.Linq;

namespace SieveOfEratosthenes_PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine(string.Join(" ", SieveOfEratosthenes(n)));
        }

        static List<int> SieveOfEratosthenes(int n)
        {
            var result = new List<int>();
            bool[] primes = Enumerable.Repeat(true, n + 1).ToArray();
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (primes[i])
                {
                    for (int j = i * i; j <= n; j+=i)
                    {
                        primes[j] = false;
                    }
                }
                
            }

            for (int i = 2; i <= n; i++)
            {
                if (primes[i])
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
