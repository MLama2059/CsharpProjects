// WorkWithIntegers(); //Method
// OrderPrecedence(); //Method
// TestLimits();
// WorkWithDoubles();
// WorkWithDecimal();
CalculateArea();

//Integers
void WorkWithIntegers()
{
    int a = 18;
    int b = 6;

    //addition
    int c = a + b;
    Console.WriteLine(c);

    //subtraction
    c = a - b;
    Console.WriteLine(c);

    //multiplication
    c = a * b;
    Console.WriteLine(c);

    //division
    c = a / b;
    Console.WriteLine(c);

    // c = a + b - 12 * 17;
    // Console.WriteLine(c);
}

//Order of operations
void OrderPrecedence()
{
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
}

void TestLimits()
{
    //Integer precision and limits
    int a = 7;
    int b = 4;
    int c = 3;
    int d = (a + b) / c;
    int e = (a + b) % c;
    Console.WriteLine($"quotient: {d}");
    Console.WriteLine($"remainder: {e}");

    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}");

    int what = max + 3;
    Console.WriteLine($"An example of overflow: {what}");
}

//Doubles
void WorkWithDoubles()
{
    double a = 5;
    double b = 4;
    double c = 2;
    double d = (a + b) / c;
    Console.WriteLine(d);

    double e = 19;
    double f = 23;
    double g = 8;
    double h = (e + f) / g;
    Console.WriteLine(h);

    double max = double.MaxValue;
    double min = double.MinValue;
    Console.WriteLine($"The range of double is {min} to {max}");

    double third = 1.0 / 3.0;
    Console.WriteLine(third);
}

//Decimal
void WorkWithDecimal()
{
    decimal min = decimal.MinValue;
    decimal max = decimal.MaxValue;
    Console.WriteLine($"The range of decimal type is {min} to {max}");

    double a = 1.0;
    double b = 3.0;
    Console.WriteLine(a / b);

    decimal c = 1.0M;
    decimal d = 3.0M;
    Console.WriteLine(c / d);
}

//Challenge
//Calculate area of a circle
void CalculateArea()
{
    double radius = 2.50;
    double area = Math.PI * radius * radius;
    Console.WriteLine($"The area of the circle is {area}.");
}