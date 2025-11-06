using System.Threading;

string message = "C# is awesome";
// Console.WriteLine(message[0]); //returns a char from the string at the specified location
// Console.WriteLine(message[1]);
// Console.WriteLine(message[2]);
// Console.WriteLine(message[3]);

for (int i = 0; i < message.Length; i++)
{
    Console.Write(message[i]);
    Thread.Sleep(100);
}

Console.WriteLine();

bool contains = false;

for (int i = 0; i < message.Length; i++)
{
    if (message[i].Equals('#'))
    {
        contains = true;
    }
}

Console.WriteLine(contains);