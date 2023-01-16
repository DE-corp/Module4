using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Напишите свой любимый цвет");

			var color = Console.ReadLine().ToLower();

			if (color == "красный")
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Твой цвет - Красный!");
			}

			else if (color == "зеленый")
			{
				Console.BackgroundColor = ConsoleColor.Green;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Твой цвет - Зеленый!");
			}
			
			else if (color == "розовый")
			{
				Console.BackgroundColor = ConsoleColor.Magenta;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Твой цвет - Розовый!");
			}

			else if (color == "серый")
			{
				Console.BackgroundColor = ConsoleColor.DarkGray;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Твой цвет - Серый!");
			}

			else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Твой цвет - Бирюзовый!");
            }

			Console.ReadKey();
        }
    }
}
