using System.ComponentModel.Design;
    
Console.WriteLine("Hi! What is your name?");
string name = Console.ReadLine();

bool keepGoing;

do
{
    Console.WriteLine(name + ", please enter a number between 1 and 100:");
    int userNumber = int.Parse(Console.ReadLine());

    bool even = userNumber % 2 == 0;

    if (!even && userNumber < 60 && userNumber >= 1)
    {
        Console.WriteLine(userNumber + " is odd and less than 60, " + name + ".");
    }
    if (even && userNumber >= 2 && userNumber <= 24)
    {
        Console.WriteLine(name + ", your number is even and less than 25.");
    }
    if (even && userNumber >= 26 && userNumber <= 60)
    {
        Console.WriteLine(userNumber + " is even and between 26 and 60 inclusive, " + name + ".");
    }
    if (even && userNumber > 60 && userNumber <= 100)
    {
        Console.WriteLine(userNumber + " is even and greater than 60, " + name + ".");
    }
    if (!even && userNumber > 60 && userNumber <=100)
    {
        Console.WriteLine(userNumber + " is odd and greater than 60, " + name + ".");
    }
    else if (userNumber > 100 || userNumber < 1)
    {
        Console.WriteLine("Incorrect input. Please enter a number between 1 and 100");
    }
    
    Console.WriteLine(name + ", do you want to continue? (yes/no)");
    keepGoing = Console.ReadLine().ToLower().Trim() == "yes";
    
}
    while (keepGoing) ;
    {
        Console.WriteLine("Bye " + name + "!");
    }

Console.ReadKey();