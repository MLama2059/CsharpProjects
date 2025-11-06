// Space characters - \t, \n, \", \\ = \
//Verbatim identifier - @

string path = "C\\Users\\Acer\\Desktop\\C#\nNew Line";
string speech = "He said \"Hello\"";
Console.WriteLine(path);
Console.WriteLine(speech);

path = @"C\\Users\Acer\Desktop\C#" + "\nNew Line";
Console.WriteLine(path);

string name = @"Hello ""there""";
Console.WriteLine(name);

name = "Hello 'there'";
Console.WriteLine(name);