// string name = string.Empty; //Empty string
Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

if (name != string.Empty)
{
    Console.WriteLine($"Your name is {name}.");
}
else
{
    Console.WriteLine("Name is empty.");
}