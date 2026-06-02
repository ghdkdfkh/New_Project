using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliklinika
{
    class Program
    {
        static void Main(string[] args)
        {
            string peopleInQueue;
            int timeForOnePeople = 10;
            int value;

            Console.WriteLine("Введите сколько перед вами очередь");
            peopleInQueue = Console.ReadLine();
            int.TryParse(peopleInQueue, out value);
            Console.WriteLine(value*timeForOnePeople + " минут осталось ждать");

        }
    }
}
