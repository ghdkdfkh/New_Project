using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityShuffle
{
    //4.3) ДЗ: Канзас сити шафл
    //Реализуйте функцию Shuffle, которая перемешивает элементы массива в случайном порядке.
    //Прежде чем приступить к выполнению задания, ознакомьтесь с материалом Перемешивание массива в C#

    class Program
    {
        static void Main(string[] args)
        {

            int[] targetArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] arrayshuffles;
            //int[] arrayshuffles = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < targetArray.Length; i++)
                Console.WriteLine("Счетчик. N элем массива - " + i
                    + "|| Значение массива - " + targetArray[i]);
            Console.ResetColor();

            Console.WriteLine();

            arrayshuffles = Shuffle(targetArray);

            //Console.ForegroundColor = ConsoleColor.Yellow;

            //for (int i = 0; i < arrayshuffles.Length; i++)
            //    Console.WriteLine("Счетчик. N элем массива - " + i
            //        + "|| Значение массива - " + arrayshuffles[i]);
            //Console.ResetColor();
            //Console.WriteLine(arrayshuffles +" - количество символов в массиве");


            Console.ReadKey();
        }
        public static int[] Shuffle(int[] array)
        {
            Random rand = new Random();

            //int[] tmpArr = new int[array.Length];

            //for (int i = 0; i < array.Length; i++)
            for (int i = array.Length-1; i >= 0; i--)
            {
                int randomIndex = rand.Next(i);
                Console.WriteLine("randomIndex " + randomIndex);

                int tmpNum = array[i];
                array[i] = array[randomIndex];
                array[randomIndex] = tmpNum;

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Счетчик. N элем массива - " + i + "|| Значение массива - " + array[i]);
                Console.ResetColor();
                Console.WriteLine();
            }

            return array;
        }

    }
}
