using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        int result = Add(5);
        Console.WriteLine(result);
    }

    static int Add(int a, [Optional] int b)
    // static int Add(int a, int b = 10)
    // static int Add(int a, int b = default) //default = 0 for this case
    {
        return a + b;
    }
}