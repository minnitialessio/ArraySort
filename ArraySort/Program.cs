using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 1, 35, 10, 6, 23, 9, 18, 11, 2, 67 };
            Array.Sort(array);

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
