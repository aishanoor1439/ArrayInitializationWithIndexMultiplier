using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInitializationWithIndexMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
            }

            Console.WriteLine("Index\tValue");
            Console.WriteLine("----------------");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}\t{array[i]}");
            }

        }
    }
}
