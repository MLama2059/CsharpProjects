class Program
{
    static void Main(string[] args)
    {
        int num1 = ReadValue("Enter the first number: ");
        int num2 = ReadValue("Enter the second number: ");
        Console.WriteLine(Add(num1, num2)); num1 and num2 are arguments
    }

    static int ReadValue(string message)
    {
        Console.WriteLine("Enter a number: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    static int Add(int a, int b) // a and b are parameters inside the parenthesis
    {
        return a + b;
    }
}