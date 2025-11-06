using System;

namespace VarKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // int age = 33;
            var age = 33;
            Console.WriteLine(age);
            Console.WriteLine(age.GetType());

            // string name = "John";
            var name = "John";
            Console.WriteLine(name);
            Console.WriteLine(name.GetType());

            // char value = 'a';
            var value = 'a';
            Console.WriteLine(value);
            Console.WriteLine(value.GetType());

            // bool what = true;
            var what = true;
            Console.WriteLine(what);
            Console.WriteLine(what.GetType());
        }
    }
}