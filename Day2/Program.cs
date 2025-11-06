// WorkWithStrings();
// WorkWithIntegers();
Challenge();

//List<T>
void WorkWithStrings()
{
    List<string> names = ["Manish", "Ana", "Felipe"];
    foreach (var name in names)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    Console.WriteLine();
    names.Add("Maria");
    names.Add("Bill");
    names.Remove("Ana");
    foreach (var name in names)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    Console.WriteLine($"My name is {names[0]}");
    Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");
    Console.WriteLine($"The lsit has {names.Count} people in it!"); //Counts the number of items in the list

    //Search list
    var index = names.IndexOf("Felipe");
    if (index == -1)
    {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
    }
    else
    {
        Console.WriteLine($"The name {names[index]} is at index {index}");
    }

    index = names.IndexOf("Not Found");
    if (index == -1)
    {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
    }
    else
    {
        Console.WriteLine($"The name {names[index]} is at index {index}");
    }

    //Sort list
    names.Sort();
    foreach (var name in names)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }
}

void WorkWithIntegers()
{
    List<int> fibonacciNumbers = [1 , 1];
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);

    foreach (var item in fibonacciNumbers)
    {
        Console.WriteLine(item);
    }
}

//Challenge
//Generate the first 20 Fibonacci numbers
void Challenge()
{
    List<int> fibonacciNumbers = [0 , 1];

    for (int i = 2; i < 20; i++)
    {
        fibonacciNumbers.Add(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]);
    }

    foreach (var item in fibonacciNumbers)
    {
        Console.WriteLine(item);
    
    }
}