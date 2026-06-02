using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_project
{

    //    4.1) ДЗ: ReadInt
    //Написать функцию, которая запрашивает число у пользователя(с помощью метода Console.ReadLine())
    //и пытается сконвертировать его в тип int (с помощью int.TryParse()) 
    //Если конвертация не удалась у пользователя запрашивается число повторно до тех пор,
    //пока не будет введено верно.
    //После ввода, который удалось преобразовать в число, число возвращается.   

    class Program
    {

        static void Main(string[] args)
        {
            int result;
            string userInput;
            bool isConverted= false;
           

            while (isConverted==false)
            {
                userInput = Console.ReadLine();              

                if (int.TryParse(userInput, out result))
                {
                    Console.WriteLine($"Ваше число успешно конвертировано\n" +
                        $"Ваше число {result}");
                    isConverted = true;
                }
                else
                {
                    Console.WriteLine("Было введено не число, введите число ");
                }

            }

        }


    }
}
