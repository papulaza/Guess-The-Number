
Random rndNum = new Random();

int num = rndNum.Next(1, 101);
Console.WriteLine("Guess a number between 1 and 100:");
int userGuess = 0;
Thread.Sleep(1000);

while (userGuess != num)
{
    Console.WriteLine("Enter your guess");
    userGuess = int.Parse(Console.ReadLine());
    if (userGuess < num)
    {
        Console.WriteLine("Too low, guess again!");
    }
    else if (userGuess > num)
    {
        Console.WriteLine("Too high, guess again!");
    }
    else { Console.WriteLine($"You found the number! it is {num} "); }
}

Console.ReadKey();