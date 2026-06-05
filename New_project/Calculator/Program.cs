using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput1;
            string userInput2;
            string userVibor;
            int result1;
            double result2;
            bool isWorking = true;


            Console.WriteLine("Введите первое число");
            userInput1 = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            userInput2 = Console.ReadLine();

            while (isWorking == true)
            {
                int.TryParse(userInput1, out result1);
                double.TryParse(userInput2, out result2);
                Console.WriteLine("Выберите дейстивие\n" +
                    "1 - сложение\n" +
                    "2 - отнимание\n" +
                    "3 - деление\n" +
                    "4 - умножение\n" +
                    "5 - выход\n");
                switch (userVibor = Console.ReadLine())
                {
                    case "1":
                        Console.Write("Ответ ");
                        Console.WriteLine(result1 + result2);
                        break;

                    case "2":
                        Console.Write("Ответ ");
                        Console.WriteLine(result1-result2);
                        break;

                    case "3":
                        Console.Write("Ответ ");
                        Console.WriteLine(result1/result2);
                        break;

                    case "4":
                        Console.Write("Ответ ");
                        Console.WriteLine(result1*result2);
                        break;

                    case "5":
                        isWorking = false;
                        break;
                    default:
                        Console.WriteLine("Введена не верная команда");
                        break;
                }
            }
        }
    }
}
