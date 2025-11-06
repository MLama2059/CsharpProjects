// Fraudulent order (Foreach statement)
string[] fraudulentOrder = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string temp in fraudulentOrder)
{
    if (temp.StartsWith("B"))
    {
        Console.WriteLine(temp);
    }
}