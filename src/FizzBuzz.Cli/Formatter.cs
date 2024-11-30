using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Cli
{
    public class Formatter
    {
        public static string FormatWithRules(int i1)
        {
            string? line;
            if (i1 % 3 == 0 && i1 % 5 == 0)
            {
                var fizzbuzz = "FizzBuzz";
                line = fizzbuzz;
            }
            else if (i1 % 3 == 0)
            {
                var fizz = "Fizz";
                line = fizz;
            }
            else if (i1 % 5 == 0)
            {
                var buzz = "Buzz";
                line = buzz;
            }
            else
            {
                line = i1.ToString();
            }
            string s = line;
            return s;
        }
    }
}
