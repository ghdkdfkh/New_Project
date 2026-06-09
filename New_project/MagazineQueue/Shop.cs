using System;
using System.Collections.Generic;

namespace MagazineQueue
{
    internal class Shop
    {
        public Dictionary<string, string> tolkoviySlovar = new Dictionary<string, string>();

        public void ShowList(Dictionary<string, string> tolkoviySlovar) //ToDo: ПЕРЕименовать методы по логике(смыслу).
        {
            foreach (var slovar in tolkoviySlovar)
                Console.WriteLine($"Слово {slovar.Key}");

            Console.WriteLine("================================");
        }

        public string SearchElementWithKey()
        {
            Console.WriteLine("Введи ключ для поиска в словаре...");
            string userInput = Console.ReadLine();

          //  if (tolkoviySlovar.ContainsKey(userInput))
                foreach (var slovar in tolkoviySlovar)
                    if (slovar.Key == userInput)
                        Console.WriteLine($"Слово {slovar.Key} - Значение - {slovar.Value}");
                    //else
                    //    Console.WriteLine("Было введено неверно слово");

            return userInput;
        }

        public Dictionary<string, string> FillDictionary()
        {
            tolkoviySlovar.Add("Приветсвие", "Действие при встречи с человеком");
            tolkoviySlovar.Add("Сон", "Биологическая потребность");
            tolkoviySlovar.Add("Москва", "Столица Российской Федерации");

            return tolkoviySlovar;
        }

        //public void ЗаполнениеСловаря(string ключ, string содержание)
        //{
        //    tolkoviySlovar.Add(ключ, содержание);
        //}
    }
}