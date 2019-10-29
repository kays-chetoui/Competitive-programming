using System;
using System.Collections.Generic;
using System.Linq;

namespace _10420_ListOfConquests
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                var str = Console.ReadLine();
                var country = str.Substring(0, str.IndexOf(" "));
                if (dict.ContainsKey(country))
                {
                    dict[country]++;
                }
                else
                {
                    dict.Add(country, 1);
                }
            }
            
            Console.WriteLine(string.Join(Environment.NewLine, dict.OrderBy(e => e.Key).Select(e => e.Key + " " + e.Value)));
        }
    }
}
