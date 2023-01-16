using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 3;

            var c = (a > b) ^ (a != b);

            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
