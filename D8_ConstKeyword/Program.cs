using System;

namespace Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            const int VAT = 13; //To declare a constant variable

            VAT = 11; //Cannot change it
            Console.WriteLine(VAT);
        }
    }
}