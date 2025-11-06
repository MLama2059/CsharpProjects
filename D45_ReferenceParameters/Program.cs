class Program
{
    static void Main(string[] args)
    {
        /*
        int num = 10;
        string name = "";
        Assign(ref num, ref name);
        Console.WriteLine(num);
        Console.WriteLine(name);
        */

        string name = "John";
        Console.WriteLine("Enter your new name: ");
        string newName = Console.ReadLine();

        if (ChangeName(ref name, newName))
        {
            Console.WriteLine($"Your new name is {name}!");
        }
        else
        {
            Console.WriteLine("New name cannot be empty or null!");
        }
    }

    static bool ChangeName(ref string name, string newName)
    {
        if (!string.IsNullOrEmpty(newName))
        {
            name = newName;
            return true;
        }
        return false;
    }

    static void Assign(ref int num, ref string name)
    {
        num = 20;
        name = "Manish";
    }
}