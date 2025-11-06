int[] numbers = new int[4]; //If we want to add five numbers in the array we need a new array as below
int[] newNumbers = new int[5];

//Lists - stores dynamically, can store data of only one data type
/*
List<int> listNumbers = new List<int>()
{
    1, 2, 3, 4, 5
};

listNumbers.Add(1);
listNumbers.Add(2);
listNumbers.Add(3);
listNumbers.Add(4);
listNumbers.Add(5);
*/

List<int> listNumbers = new List<int>();

for (int i = 0; i < 3; i++)
{
    Console.Write("Enter a number: ");
    listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
}

for (int i = 0; i < listNumbers.Count; i++)
{
    Console.WriteLine(listNumbers[i]);
}

Console.WriteLine("");
listNumbers.RemoveAt(0);

foreach (int item in listNumbers)
{
    Console.WriteLine(item);
}