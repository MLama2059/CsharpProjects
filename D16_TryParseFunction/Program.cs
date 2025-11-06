// Console.Write("Enter a number: ");
// string input = Console.ReadLine(); //10h - Gives exception with characters at end
// int num = Convert.ToInt32(input);
// Console.WriteLine(num);

// int.TryParse(input, out num);

bool success = true;

while (success)
{
    Console.Write("Enter a number:");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int num))
    {
        success = false;
        Console.WriteLine(num);
    }
    else
    {
        Console.WriteLine("Failed to convert!");
    }
}
