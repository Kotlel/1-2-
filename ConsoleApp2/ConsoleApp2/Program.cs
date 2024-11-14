using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
             // Task 1
             Console.WriteLine("MinByte {0}", Byte.MinValue);
             Console.WriteLine("MinInt16 {0}", Int16.MinValue);
             Console.WriteLine("MinChar {0}", Char.MinValue);
             Console.WriteLine("MinDouble {0}", Double.MinValue);
             Console.WriteLine("MinDecimal {0}", Decimal.MinValue);

             
             Console.WriteLine("MaxByte {0}", Byte.MaxValue);
             Console.WriteLine("MaxInt16 {0}", Int16.MaxValue);
             Console.WriteLine("MaxChar {0}", Char.MaxValue);
             Console.WriteLine("MaxDouble {0}", Double.MaxValue);
             Console.WriteLine("MaxDecimal {0}", Decimal.MaxValue);

        }
    }
}
