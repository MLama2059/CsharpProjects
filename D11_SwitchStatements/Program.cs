Console.Write("Enter a day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.Write("Sunday");
        break;

    case 2:
        Console.Write("Monday");
        break;

    case 3:
        Console.Write("Tuesday");
        break;

    case 4:
        Console.Write("Wednesday");
        break;

    case 5:
        Console.Write("Thursday");
        break;

    case 6:
        Console.Write("Friday");
        break;
    case 7:
        Console.Write("Saturday");
        break;

    default:
        Console.WriteLine("Invalid number.");
        break;
}