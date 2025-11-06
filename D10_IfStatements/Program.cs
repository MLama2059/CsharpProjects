class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();
        int age = Convert.ToInt32(input);
        
        if (age == 18)
        {
            Console.WriteLine("You are 18");
        }
        else if (age < 18)
        {
            Console.WriteLine("You are under 18");
        }
        else
        {
            Console.WriteLine("You are above 18");
        }
    }
}