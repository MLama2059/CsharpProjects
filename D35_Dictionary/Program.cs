//Dictionary can store items of different data types
/*
Dictionary<int, string> names = new Dictionary<int, string>();

//Key Value Pair
names.Add(1, "Manish"); //Keys must be unique
names.Add(2, "Anisha");
names.Add(3, "Roshika");

for (int i = 0; i < names.Count; i++)
{
    // Console.WriteLine(names[i]); //Not possible to print like this
    KeyValuePair<int, string> pair = names.ElementAt(i);
    Console.WriteLine($"{pair.Key} - {pair.Value}");
}

Console.WriteLine("");
foreach (var item in names)
//Or
// foreach (KeyValuePair<int, string> item in names)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}
*/

Dictionary<string, string> teachers = new Dictionary<string, string>
{
    {"Math", "Bishal"},
    {"English", "Chandra"}
};

// Console.WriteLine(teachers["Math"]);

if (teachers.TryGetValue("Math", out string teacher))
{
    Console.WriteLine(teacher);
}
else
{
    Console.WriteLine("Math teacher not found");
}

foreach (var item in teachers)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}