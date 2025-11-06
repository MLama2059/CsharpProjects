/*
Create two lists with integer data types, one for even numbers, one for odd
Loop from 0-20
    If number is even, add to even list
    If number is odd, add to odd list
Print even list
Print odd list
*/

List<int> even = new List<int>();
List<int> odd = new List<int>();

for (int i = 0; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        even.Add(i);
    }
    else
    {
        odd.Add(i);
    }
}

Console.WriteLine("Even numbers: ");
foreach (int data in even)
{
    Console.Write($"{data} ");
}

Console.WriteLine(Environment.NewLine + "Odd numbers: ");
foreach (int data in odd)
{
    Console.Write($"{data} ");
}