//While loop
/*
int a = 0;

while (a < 5)
{
    Console.WriteLine(a);
    a++;
}
*/

//Do while loop
/*
int a = 1;
do
{
    Console.WriteLine(a);
    a++;
} while(a < 5);
*/

Console.Write("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int answer = num1 * num2;
int userAnswer = 0;

Console.WriteLine("");
Console.WriteLine("What is the value of " + num1 + "x" + num2 + "?");

/*
while (userAnswer != answer)
{
    Console.Write("Enter your answer: ");
    userAnswer = Convert.ToInt32(Console.ReadLine());

    if (userAnswer != answer)
    {
        Console.WriteLine("Wrong answer. Try again!");
    }

    else
    {
        Console.WriteLine("Well done!");
    }
}
*/

do
{
    Console.Write("Enter your answer: ");
    userAnswer = Convert.ToInt32(Console.ReadLine());

    if (userAnswer != answer)
    {
        Console.WriteLine("Wrong answer. Try again!");
        Console.WriteLine("");
    }
} while (userAnswer != answer);

Console.WriteLine("Well done!");