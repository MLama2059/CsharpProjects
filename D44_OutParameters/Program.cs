class Program
{
    static void Main(string[] args)
    {
        // int num = 0;
        // bool success = test(out num);
        // Console.WriteLine(num);
        // Console.WriteLine(success);

        List<string> shoppingList = new List<string>
        {
            "Coffee", "Milk", "Tea"
        };

        Console.WriteLine(shoppingList.IndexOf("Milk"));

        Console.WriteLine("Enter an item to search: ");
        string search = Console.ReadLine();

        if (FindInList(search, shoppingList, out int index))
        {
            Console.WriteLine($"Found {search} at index {index}");
        }
        else
        {
            Console.WriteLine("Not found");
        }
        
        static bool FindInList(string s, List<string> list, out int index)
        {
            index = -1;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(s.ToLower()))
                {
                    index = i;
                }
            }
            return index > -1;
        }
    }

    static bool test(out int num)
    {
        num = 5;
        return true;
    }
}
