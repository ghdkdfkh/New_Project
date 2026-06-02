using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthBarUI
{
    //4.2) ДЗ: UIElement
    //Разработайте функцию, которая рисует некий бар(Healthbar, Manabar) в определённой позиции.
    //Функция принимает некий закрашенный процент, длину бара и при необходимости дополнительные параметры.
    //При 40% бар выглядит так:  [####______] 

    //Реализуйте показ данных здоровья и маны.
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            int health = 5, maxHealth = 10;
            int mana = 8, maxMana = 10;

            while (isWorking==true)
            {
                DrawBar(health, maxHealth, ConsoleColor.DarkGreen, 0, '#');
                DrawBar(mana, maxMana, ConsoleColor.DarkBlue, 1, '^');

                Console.SetCursorPosition(0, 4);
                Console.Write("Введите количество здоровья ");
                health += Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество маны ");
                mana += Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите exit для выхода");
                if (Console.ReadLine() == "exit")
                {
                    isWorking = false;
                }
                Console.Clear();
            }
        }
        static void DrawBar(int value, int maxValue, ConsoleColor color, int position, char symbol)
        {
            string bar = "";
            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }
            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.ResetColor();

            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += " ";
            }

            Console.Write(bar + ']');
        }
    }
}
