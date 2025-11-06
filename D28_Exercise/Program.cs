/*
Ask user to enter password, and store
Ask user to enter password again, and store
Check if they are both containing something
    If so check if they are the same
        If they are, print "Passwords match"
        If they are not, print "Passwords do not match"
    If they are empty, print "Please enter a password"
*/

Console.Write("Enter password: ");
string password = Console.ReadLine();

Console.Write("Enter password again: ");
string again = Console.ReadLine();

if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(again))
{
    if (again.Equals(password))
    {
        Console.WriteLine("Passwords match");
    }
    else
    {
        Console.WriteLine("Passwords do not match");
    }
}
else
{
    Console.WriteLine("Please enter a password");
}