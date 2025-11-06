namespace StringAndChar
{
    class Program
    {
        static void Main(string[] args)
        {
            // String
            string name = "Manish";
            //Character
            char letter = 'A'; //Char cannot be empty

            Console.Write("My name is ");
            Console.Write(name);
            Console.WriteLine();
            Console.WriteLine(letter);

            Console.WriteLine("Enter your name:");
            string? Name = Console.ReadLine();
            Console.Write("Your name is ");
            Console.Write(Name + ".");
        }
    }
}