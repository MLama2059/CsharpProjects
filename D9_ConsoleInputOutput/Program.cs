using System;

namespace ConsoleIO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine(); //To read input from the user
            // Console.WriteLine(name);

            Console.Write("Enter your age: ");
            // string ageInput = Console.ReadLine();
            // int age = Convert.ToInt32(ageInput);
            int age = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Your name is ");
            // Console.Write(name);
            // Console.Write(" and your age is ");
            // Console.Write(age);
            Console.WriteLine("Your name is " + name + " and your age is " + age + ".");
        }
    }
}