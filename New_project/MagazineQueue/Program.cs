using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazineQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            Dictionary<string, string> tolkoviySlovar = new Dictionary<string, string>();
            tolkoviySlovar.Add("Приветсвие", "Действие при встречи с человеком");
            tolkoviySlovar.Add("Сон", "Биологическая потребность");
            tolkoviySlovar.Add("Москва", "Столица Российской Федерации");
            foreach (var slovar in tolkoviySlovar)
            {
                Console.WriteLine($"Слово {slovar.Key}");
            }
            userInput = Console.ReadLine();
            if (tolkoviySlovar.ContainsKey(userInput))
            {
                foreach (var slovar in tolkoviySlovar)
                {
                    Console.WriteLine($"Слово {slovar.Key} - Значение {slovar.Value}");
                }
            }
            else
            {
                Console.WriteLine("Было введено неверно слово");
            }
            

        }
    }
}
