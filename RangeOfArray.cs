using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertysPractice
{
    
    public class RangeOfArray<T>
    {
        private T[] arr;
        public int LowerBound { get; set; }
        public int UpperBound { get; set; }

        public RangeOfArray(int size)
        {
            arr = new T[size];
        }

        public T this[int i]
        {
            get
            {
                if (i > LowerBound && i < UpperBound)
                {
                    return arr[i - LowerBound];
                }
                return arr[0];
            }

            set
            {
                if (i > LowerBound && i < UpperBound)
                {
                    arr[i - LowerBound] = value;
                }
            }
        }
    }
}