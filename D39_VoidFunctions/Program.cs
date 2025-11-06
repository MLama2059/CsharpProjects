class Program
{
    static void Main(string[] args)
    {
        ArrayFunction();
    }

    static void ArrayFunction() //Void functions returns nothing and ends without returning anything
    {
        int[] numbers = new int[5] { 1, 2, 3, 4, 5};

        foreach (int i in numbers)
        {
            Console.Write($"{i} ");
        }
    }
}
