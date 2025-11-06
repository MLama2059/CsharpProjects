Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

Console.WriteLine($"Your name is  {name}");

//Risky can give exception
/*
if (name != "")
    Console.WriteLine("0");

if (!name.Equals(""))
    Console.WriteLine("1");
*/

if (!string.IsNullOrEmpty(name)) //Checks whether the string is Null(Null) or Empty("")
    Console.WriteLine("3");