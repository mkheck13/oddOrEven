// Odd or Even

bool playAgain = true;
int userNum;
string breakLine = "-----------------------------------------------";

Console.Clear();

while (playAgain)
{
    Console.WriteLine(breakLine);
    Console.WriteLine("Today we are going to checking if a number is Odd or Even.");
    Console.WriteLine("Please enter a number.");
    Console.WriteLine(breakLine);
    bool isNum = Int32.TryParse(Console.ReadLine(), out userNum);



    while (true)
    {

        if (!isNum)
        {
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("That doesn't seem to be a number.");
            Console.WriteLine("Maybe your finger slipped. Let's try entering a number again.");
            Console.WriteLine(breakLine);
            isNum = Int32.TryParse(Console.ReadLine(), out userNum);
        }
        else if (userNum % 2 == 0)
        {
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine($"Well, {userNum} seems to be an even number. Good Job!");
            // isNum = true;
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine($"Look at that, {userNum} is looking like an odd number.");
            // isNum = true;
            break;
        }

    }
    Console.WriteLine("Would you like to play again yes/no.");
    Console.WriteLine(breakLine);

    bool yesNo = true;

    while (yesNo == true)
    {
        string? userInput = Console.ReadLine();
        if (userInput?.ToLower() == "yes")
        {
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("Looks like we are going again!");
            yesNo = false;
        }
        else if (userInput?.ToLower() == "no")
        {
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("Til next time.");
            Console.WriteLine(breakLine);
            yesNo = false;
            playAgain = false;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("That doesn't seem to be a yes or a no. How about you try that again.");
            Console.WriteLine(breakLine);
        }
    }


}