/*
FizzBuzz Game
Create a for loop from 1 to x(15 in this case)
3 and 5 = FizzBuzz
3 = Fizz
5 = Buzz
else = number
*/

for (int i = 1; i <= 15; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }

    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }

    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }

    else
    {
        Console.WriteLine(i);
    }
}