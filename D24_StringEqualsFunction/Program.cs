string message = "Hello";
string compare = "Hello";

// if (message == compare)
if (message.Equals(compare))
{
    Console.WriteLine("Same");
}
else
{
    Console.WriteLine("Different");
}

string name = "Naruto";

if (!name.Equals(""))
{
    Console.WriteLine($"Your name is {name}.");
}
else
{
    Console.WriteLine("Invalid name input.");
}