using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10] { -1, -2, 10, -4, -5, 6, 10, 8, 9, 10 };
            int[] arr2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            var print = from i in arr1
                       select i;
            foreach (var val in arr1)
                Console.Write(val+" ");
            Console.WriteLine();

            var print2 = from i in arr2
                        select i;
            foreach (var val in arr2)
                Console.Write(val + " ");
            Console.WriteLine("\n");

            var result = arr1.Except(arr2);

            foreach (var s in result)
                Console.Write(s+" ");
            Console.WriteLine('\n');

            result = arr1.Intersect(arr2);

            foreach (var s in result)
                Console.Write(s+" ");
            Console.WriteLine('\n');

            result = arr1.Union(arr2);

            foreach (var s in result)
                Console.Write(s+" ");
            Console.WriteLine('\n');

            result = result.Distinct();
            foreach (var s in result)
                Console.Write(s+" ");
            Console.WriteLine('\n');
        }
    }
}
