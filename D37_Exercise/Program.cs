/*
Define and initialise two integers (num, length)
(7, 5) -> [7, 14, 21, 28, 35]
Create int array with size length
Loop through and insert the (loop counter * num) into the array
Print the final array
*/

int num = 7;
int length = 5;
int[] result = new int[length];
int counter = 0;

for (int i = 1; i <= result.Length; i++, counter++)
{
    result[counter] = num * i;
    // counter++;
}

foreach (var item in result)
{
    Console.Write($"{item} ");
}