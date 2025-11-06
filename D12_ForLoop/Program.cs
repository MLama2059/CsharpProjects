Console.WriteLine("How many times do you want to say Hi?");
int loop = Convert.ToInt32(Console.ReadLine());

if (loop == 0)
{
    Console.WriteLine("Enter number greater than 0!");
}

else
{
    for (int i = 0; i < loop; i++)
    {
        Console.WriteLine("Hello");
    }
}

Console.WriteLine("");

for (int i = 0; i < 10; i += 2) //Even numbers
{
    Console.WriteLine(i);
}