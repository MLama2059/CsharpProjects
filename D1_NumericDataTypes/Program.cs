namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integer
            int age = 23;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            //Long
            long bigNumber = 100000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            //Double
            double negative = 45.8D;
            Console.WriteLine(negative);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            //Float
            float precision = 5.00001F;
            Console.WriteLine(precision);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            //Decimal
            decimal money = 12.34M;
            Console.WriteLine(money);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
        }
    }
}