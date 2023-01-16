using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5 + 6;  //11
            int b = 7 + 8;  //15

            bool c = (b == a) & (b > a + 1);
            bool d = (b == a) && (b > a + 1);

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
