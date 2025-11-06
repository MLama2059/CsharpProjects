int[] numbers = new int[]
{
    0, 1, 2, 3, 4, 5
};

/*
int[] sortedArray = new int[numbers.Length];
int x = 0;

for (int i = numbers.Length - 1; i >= 0; i--)
{
    sortedArray[x] = numbers[i];
    x++;
}

foreach (int num in sortedArray)
{
    Console.Write($"{num} ");
}
*/

Array.Reverse(numbers); //Reverses the array

foreach (int num in numbers)
{
    Console.Write($"{num} ");
}