// int num1 = 5;
// int num2 = 10;
// int num3 = 15;

int[] numbers = new int[5];
// numbers[0] = 5;
// numbers[1] = 10;
// numbers[2] = 15;

/*
numbers[0] = Convert.ToInt32(Console.ReadLine());
numbers[1] = Convert.ToInt32(Console.ReadLine());
numbers[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num1} {num2} {num3}");
Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");
*/


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter a number: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(numbers[i]);
}

Console.WriteLine("");

foreach (int i in numbers) //Used to iterate over all the elements in the array
{
    Console.WriteLine(i);
}