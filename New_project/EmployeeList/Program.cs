using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    //    4.4) ДЗ: Кадровый учет
    //        Будет 2 одномерных массива:
    //1) Полные имена сотрудников(фамилия, имя, отчество);
    //2) Должности.

    //Описать функцию заполнения массивов досье, функцию форматированного вывода, функцию поиска по фамилии и функцию удаления досье.
    //Функция добавления элемента расширяет уже имеющийся массив на 1 и дописывает туда новое значение.

    //Программа должна быть с меню, которое содержит пункты:  
    //1) добавить досье
    //2) вывести все досье(в одну строку через “-” фио и должность с порядковым номером в начале)
    //3) удалить досье(Удаление должно быть конкретного элемента, указанного пользователем. Массивы уменьшаются на один элемент.
    //Нужны дополнительные проверки, чтобы не возникало ошибок)
    //4) поиск по фамилии(показ всех с данной фамилией)
    //5) выход
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesOfEmployee = new string[0];
            string[] dolznostOfEmployee = new string[0];
            bool isWorking = true;
            string userInput;

            while (isWorking == true)
            {
            Console.WriteLine("1) добавить досье\n" +
                "2) вывести все досье\n" +
                "3) удалить досье\n" +
                "4) поиск по фамилии\n" +
                "5) выход\n");
                switch (userInput=Console.ReadLine())
                {
                    case "1":
                        break;
                    
                    case "2":
                        break;
                    
                    case "3":
                        break;
                    
                    case "4":
                        break;
                    
                    case "5":
                        Console.WriteLine("Производится выход");
                        isWorking = false;
                        break;

                    default:
                        Console.WriteLine("Такой команды нет");
                        break;
                }
            }
        }
    }
}
