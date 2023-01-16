using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Напишите свой любимый цвет");

			var color = Console.ReadLine().ToLower();

            switch (color)
            {
				case "красный":
					Console.BackgroundColor = ConsoleColor.Red;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Твой цвет - Красный!");
					break;

				case "зеленый":
					Console.BackgroundColor = ConsoleColor.Green;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Твой цвет - Зеленый!");
					break;

				case "розовый":
					Console.BackgroundColor = ConsoleColor.Magenta;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Твой цвет - Розовый!");
					break;

				case "серый":
					Console.BackgroundColor = ConsoleColor.DarkGray;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Твой цвет - Серый!");
					break;

				case "бирюзовый":
					Console.BackgroundColor = ConsoleColor.Cyan;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Твой цвет - Бирюзовый!");
					break;

				default:
					Console.BackgroundColor = ConsoleColor.Yellow;
					Console.ForegroundColor = ConsoleColor.Red;

					Console.WriteLine("Твой цвет - Другой!");
					break;
			}
	
			Console.ReadKey();
        }
    }
}
