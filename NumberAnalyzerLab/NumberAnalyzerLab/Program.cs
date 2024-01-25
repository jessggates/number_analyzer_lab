using System.ComponentModel.Design;

Console.WriteLine("Hi! What is your name?");
string name = Console.ReadLine();

Console.WriteLine(name + " ,please enter a number between 1 and 100:");
int userNumber = int.Parse(Console.ReadLine());

bool even = userNumber % 2 == 0;

if (!even && userNumber < 60)
    {
        Console.WriteLine(userNumber + " is odd and less than 60, " + name ".");
    }
    else if (even && userNumber >= 2 && userNumber <= 24)
    {
        Console.WriteLine(name + " ,your number is even and less than 25.");
    }
    else if (even && userNumber >= 26 && userNumber <= 60)
    {
        Console.WriteLine(userNumber + " is even and between 26 and 60 inclusive, " + name + ".");
    }
    else if (!even && userNumber > 60)
    {
        Console.WriteLine(userNumber + " is odd and greater than 60, " + name + ".");
    }
    else
    {
        Console.WriteLine(///don't know what to put here yet come back to tomorrow);
                }




