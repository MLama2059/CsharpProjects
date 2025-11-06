/*
Ask user to input message
Print in order
Print in reverse
*/

Console.WriteLine("Enter a message: ");
string message = Console.ReadLine();

//Order
for (int i = 0; i < message.Length; i++)
{
    Console.Write(message[i]);
}
Console.WriteLine();

//Reverse
for (int i = message.Length - 1; i >= 0; i--)
{
    Console.Write(message[i]);
} 