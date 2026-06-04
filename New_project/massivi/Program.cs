using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massivi
{

    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[10];
            int maxElement = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
                Console.WriteLine("Элемент массива - " + array[i]);
                if (maxElement < array[i])
                {
                    maxElement = array[i];
                }
            }
            Console.WriteLine("максимальный элемент массива - " + maxElement);
        }
    }
}
