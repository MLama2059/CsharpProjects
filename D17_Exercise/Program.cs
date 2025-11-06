// Ask the user for a number and use a for loop to print its multiplication table

Console.WriteLine("Enter a number for the multiplication table: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    // Console.WriteLine(number + " x " + i + " = " + number * i);
    Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
}