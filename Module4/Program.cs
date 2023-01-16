using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 1;
            int B = 4;
            double X = 1.3;
            double Y = 4.1;

            bool C = (A < B) | (X > Y);

            Console.WriteLine($"bool C = {C}");
            Console.ReadKey();        
        }
    }
}
