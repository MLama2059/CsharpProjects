class Program
{
    static void Main(string[] args)
    {
        string nameInput = "John";
        int ageInput = 5;
        string addressInput = "New Road";

        PrintDetails(address: addressInput, age: ageInput, name: nameInput); //Named parameters - can be used to give arguments in any order
    }

    static void PrintDetails(string name, string address, int age)
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Address: {address}");
        Console.WriteLine($"Age: {age}");
    }
}