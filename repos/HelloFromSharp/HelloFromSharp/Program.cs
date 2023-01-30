// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Everybody!");
Console.WriteLine("Please enter your name");
string name = Console.ReadLine();

NewMethod(name);
Console.WriteLine("Please enter your last name: " );
string lastName = Console.ReadLine();
Console.WriteLine( "Hello " + name + " " + lastName);

static void NewMethod(string name)
{
    Console.WriteLine("Hello " + name);
}