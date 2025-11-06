class Program
{
    static void Main(string[] args)
    {
        // Console.Title = "Introduction"; //Gives title to the console window
        PrintIntroduction();
    }

    static string ReturnName() //Type String - returns a string value
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine(); 
        return name;
    }

    static int ReturnAge() //Returns int value
    {
        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        return age;
    }

    static void PrintIntroduction()
    {
        Console.WriteLine($"Hello, my name is {ReturnName()} and my age is {ReturnAge()}.");
    }
}