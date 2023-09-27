using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array<int> arr1 = new Array<int>(9);
            for (int i = 0; i < arr1.Size; ++i)
            {
                arr1[i] = i;
            }
            Console.WriteLine($"arr1: {arr1}\n");

            Array<int> arr2 = new Array<int>(9);
            for (int i = 0; i < arr2.Size; ++i)
            {
                arr2[i] = i + 3;
            }
            Console.WriteLine($"arr2: {arr2}\n");

            Array<int> arr3 = arr1 + arr2;
            Console.WriteLine($"arr3: {arr3}\n");
        }
    }
}
