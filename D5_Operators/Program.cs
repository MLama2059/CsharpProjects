namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            //age = age + 1;
            age++;
            Console.WriteLine(age);
            age--;
            Console.WriteLine(age);

            age += 1;
            Console.WriteLine(age);
            age -= 1;
            Console.WriteLine(age);
            age *= 2;
            Console.WriteLine(age);
            age /= 2;
            Console.WriteLine(age);

            int i = 0;
            Console.WriteLine(i);
            Console.WriteLine(++i);
            Console.WriteLine(i++);
            Console.WriteLine(i);
        }
    }
}