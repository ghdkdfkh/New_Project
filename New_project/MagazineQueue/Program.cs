using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagazineQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop_1 = new Shop();

            shop_1.ShowList(shop_1.FillDictionary());
            //shop_1.ЗаполнениеСловаря("кл1111","впаывпывпвае");
           // shop_1.ShowList();
            shop_1.SearchElementWithKey();
            //shop_1.ShowKey();





            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }
    }
}
