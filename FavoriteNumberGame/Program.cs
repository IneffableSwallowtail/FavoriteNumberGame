// See https://aka.ms/new-console-template for more information
var r = new Random();
int favNumber = r.Next(1, 1000);
Console.WriteLine("Guess a number between 1 and 1000");

for (string end = "not yet"; end != "now"; )
{
    int userInput = int.Parse(Console.ReadLine());
    if (userInput < favNumber) { Console.WriteLine("Too low"); }
    else if (userInput > favNumber) { Console.WriteLine("Too high"); }
    else if (userInput == favNumber)
    {
        Console.WriteLine("You guessed it!");
        end = "now";
    }
    else { Console.WriteLine("Invalid entry"); }
}