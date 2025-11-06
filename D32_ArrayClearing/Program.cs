int[] numbers = new int[]
{
    0, 1, 2, 3, 4, 5
};

Array.Clear(numbers, 0, numbers.Length); //Sets the values to default 0, here 0 = starting index, numbers.Length = ending index

foreach (var num in numbers)
{
    Console.Write($"{num} ");
}