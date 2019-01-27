using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            RangeOfArray<int> array = new RangeOfArray<int>(7);
            array.LowerBound = 3;
            array.UpperBound = 10;
            array[4] = 213;
            Console.WriteLine(array[4]);
            Console.ReadLine();
        }
    }
}
