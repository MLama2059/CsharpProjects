int[] numbers = new int[]
{
    8, 3, 4, 5, 6, 6, 1, 2, 9, 7
};

Array.Sort(numbers); //Sorts the given array and returns the same array

foreach (int num in numbers)
{
    Console.Write($"{num} ");
}