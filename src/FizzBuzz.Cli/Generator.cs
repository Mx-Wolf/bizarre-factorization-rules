using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Cli
{
    public class Generator(int start, int count)
    {
        public IEnumerable<string> AllLines()
        {
            return Enumerable.Range(start, count).Select((i) => new Formatter(i).FormatWithRules());
        }
    }
}
