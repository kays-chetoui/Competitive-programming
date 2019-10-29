using System;
using System.Linq;

namespace _11559_EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = string.Empty;
            while (!string.IsNullOrEmpty(firstLine = Console.ReadLine()))
            {
                var ints = firstLine.Split().Select(int.Parse).ToArray();
                var exist = false;
                var minCost = 500001;
                for (int i = 0; i < ints[2]; i++)
                {
                    var nightPrice = int.Parse(Console.ReadLine());
                    var avaiblesBed = Console.ReadLine().Split().Select(int.Parse);
                    if (ints[0] * nightPrice <= ints[1] && avaiblesBed.Any(e => e >= ints[0]))
                    {
                        exist = true;
                        minCost = ints[0] * nightPrice;
                    }
                }
                
                Console.WriteLine(exist ? minCost.ToString() : "stay home");
            }
        }
    }
}
