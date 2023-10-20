Console.WriteLine("Are you coming or going. (in/out)");

string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    Console.WriteLine("Hello, world!");
}
else
{
    Console.WriteLine("See you later aligator.");
}

PrintHello();
PrintGoodBye();

static void PrintHello()
{
    Console.WriteLine("Hello, world!");
}
static void PrintGoodBye()
{
    Console.WriteLine("See you later aligator.");
}
