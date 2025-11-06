namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integer
            string T_age = "22";
            int age = Convert.ToInt32(T_age);
            Console.WriteLine(age);

            //Long
            string T_bigNumber = "1000000000";
            long bigNumber = Convert.ToInt64(T_bigNumber);
            Console.WriteLine(bigNumber);

            //Double
            string T_negative = "-45.8";
            double negative = Convert.ToDouble(T_negative);
            Console.WriteLine(negative);

            //Float
            string T_precision = "5.00001";
            float precision = Convert.ToSingle(T_precision);
            Console.WriteLine(precision);

            //Decimal
            string T_money = "12.34";
            decimal money = Convert.ToDecimal(T_money);
            Console.WriteLine(money);
        }
    }
}