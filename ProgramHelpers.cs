


using static System.Formats.Asn1.AsnWriter;

internal static class ProgramHelpers
{

    public static void AdditionGame(string message)
    {
        Console.WriteLine(message);


        // creating a "RANDOM" instance from the random c# class

        // "random" variable which will be used as it's created

        var random = new Random();



        /* two numbers that will be generated between 1 and 9 using the "random" variable and the RANDOM class from C# library */
        int firstNumber;
        int secondNumber;
        int numTurns = 0;
        int numIncorrGuesses = 0;
        var score = 0;







        // while loop to keep the game going in a certain rate (set for 5 times)

        for (int i = 0; i < 5; i++)
        {
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);


            Console.WriteLine($@" What is {firstNumber} + {secondNumber} = ?");
            string guess = Console.ReadLine();

            int guessToNum = int.Parse(guess);
            if (guessToNum == firstNumber + secondNumber)
            {
                Console.WriteLine("You are right!");
                score++;
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect");
                numIncorrGuesses++;
                Console.WriteLine("Press any key to continue. ");
                Console.ReadLine();
            }
            if (numIncorrGuesses >= 3)
            {
                int finalResult = score - numIncorrGuesses;
                Console.WriteLine($"Game over, too many incorrect guesses. Score : {finalResult}");
                Console.Beep();
                Environment.Exit(1);
            }

            if (i == 4)
            {
                int finalResult = score - numIncorrGuesses;
                Console.WriteLine($@"Game over, Thanks for playing! Your final score is : {finalResult}");

                Console.WriteLine("Tap any key to continue.");

                Console.ReadLine();

                Console.WriteLine("Would you like to play again?");

                string playAgain = Console.ReadLine();



            }

        }


    }



    public static void Subtraction(string message)
    {
        Console.WriteLine(message);


        // creating a "RANDOM" instance from the random c# class

        // "random" variable which will be used as it's created

        var random = new Random();



        /* two numbers that will be generated between 1 and 9 using the "random" variable and the RANDOM class from C# library */
        int firstNumber;
        int secondNumber;
        int numTurns = 0;
        int numIncorrGuesses = 0;
        var score = 0;







        // while loop to keep the game going in a certain rate (set for 5 times)

        for (int i = 0; i < 5; i++)
        {

            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);


            Console.WriteLine($@" What is {firstNumber} - {secondNumber} = ?");
            string guess = Console.ReadLine();

            int guessToNum = int.Parse(guess);




            if (guessToNum == firstNumber - secondNumber)
            {
                Console.WriteLine("You are right!");
                score++;
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect");
                numIncorrGuesses++;
                Console.WriteLine("Press any key to continue. ");
                Console.ReadLine();
            }
            if (numIncorrGuesses >= 3)
            {
                int finalResult = score - numIncorrGuesses;
                Console.WriteLine($"Game over, too many incorrect guesses. Score : {finalResult}");
                Console.Beep();
                Environment.Exit(1);
            }

            if (i == 4)
            {
                int finalResult = score - numIncorrGuesses;
                Console.WriteLine($@"Game over, Thanks for playing! Your final score is : {finalResult}");
            }



        }
    }



    public static void Multiplication(string message)
    {
        Console.WriteLine(message);


        // creating a "RANDOM" instance from the random c# class

        // "random" variable which will be used as it's created

        var random = new Random();



        /* two numbers that will be generated between 1 and 9 using the "random" variable and the RANDOM class from C# library */
        int firstNumber;
        int secondNumber;
        int numTurns = 0;
        int numIncorrGuesses;







        // while loop to keep the game going in a certain rate

        for (int i = 0; i < 5; i++)
        {

            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);
            numIncorrGuesses = 0;
            int score = 0;
            Console.WriteLine($@" What is {firstNumber} * {secondNumber} = ?");
            string guess = Console.ReadLine();

            int guessToNum = int.Parse(guess);


            if (guessToNum == firstNumber * secondNumber)
            {
                Console.WriteLine("You are right!");
                score++;
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect");
                numIncorrGuesses++;
                Console.WriteLine("Press any key to continue. ");
                Console.ReadLine();
            }
            if (numIncorrGuesses >= 3)
            {
                int finalResult = score - numIncorrGuesses;
                Console.WriteLine($"Game over, too many incorrect guesses. Score : {finalResult}");
                Console.Beep();
                Environment.Exit(1);
            }

            if (i == 4)
            {
                int finalResult = score - numIncorrGuesses;
                Console.WriteLine($@"Game over, Thanks for playing! Your final score is : {finalResult}");
            }


        }
    }

    



    public static void Division(string message)
    {


        int numIncorrGuesses = 0;
        int score = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);
            var divisionNumbers = GetDivisionNumbers();
            int firstNumber = divisionNumbers[0];
            int secondNumber = divisionNumbers[1];

            Console.WriteLine($"What is {divisionNumbers[0]} / {divisionNumbers[1]} ?");
            var answer = Console.ReadLine();

            int guessToNum = int.Parse(answer);


            if (guessToNum == divisionNumbers[0] / divisionNumbers[1])
            {
                Console.WriteLine("You are right!");
                score++;
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect");
                numIncorrGuesses++;
                Console.WriteLine("Press any key to continue. ");
                Console.ReadLine();
            }
            if (numIncorrGuesses >= 3)
            {
                int finalResult = score - numIncorrGuesses;
                Console.WriteLine($"Game over, too many incorrect guesses. Score : {finalResult}");
                Console.Beep();
                Environment.Exit(1);
            }

            if (i == 4)
            {
                int finalResult = score - numIncorrGuesses;
                Console.WriteLine($@"Game over, Thanks for playing! Your final score is : {finalResult}");
            }
        }


    }

    public static int[] GetDivisionNumbers()
    {
        //Create a method that will produce division results that are integers. 
        var random = new Random();
        var firstNumber = random.Next(1, 99);
        var secondNumber = random.Next(1, 99);
        var result = new int[2];
        var numGuesses = 0;

        result[0] = firstNumber;
        result[1] = secondNumber;

        while (firstNumber % secondNumber != 0)
        {

            firstNumber = random.Next(1, 99);
            secondNumber = random.Next(1, 99);
            result = new int[2];

            result[0] = firstNumber;
            result[1] = secondNumber;

        }







        return result;
    }


    public static void RandomChoiceOption(string message)
    {

        Console.WriteLine(message);


        // creating a "RANDOM" instance from the random c# class

        // "random" variable which will be used as it's created

        var random = new Random();



        /* two numbers that will be generated between 1 and 9 using the "random" variable and the RANDOM class from C# library */
        int firstNumber;
        int secondNumber;
        int numTurns = 0;
        int numIncorrGuesses = 0;
        var score = 0;







        // while loop to keep the game going in a certain rate (set for 5 times)

        for (int i = 0; i < 5; i++)
        {
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);


            Console.WriteLine($@" What is {firstNumber} + {secondNumber} = ?");
            string guess = Console.ReadLine();

            int guessToNum = int.Parse(guess);
            if (guessToNum == firstNumber + secondNumber)
            {
                Console.WriteLine("You are right!");
                score++;
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect");
                numIncorrGuesses++;
                Console.WriteLine("Press any key to continue. ");
                Console.ReadLine();
            }
            if (numIncorrGuesses >= 3)
            {
                int finalResult = score - numIncorrGuesses;
                Console.WriteLine($"Game over, too many incorrect guesses. Score : {finalResult}");
                Console.Beep();
                Environment.Exit(1);
            }

            if (i == 4)
            {
                int finalResult = score - numIncorrGuesses;
                Console.WriteLine($@"Game over, Thanks for playing! Your final score is : {finalResult}");

                Console.WriteLine("Tap any key to continue.");

                Console.ReadLine();

                Console.WriteLine("Would you like to play again?");

                string playAgain = Console.ReadLine();



            }

        }


    }



    public static int[] GameRandomizer()

        // Create a separate method that will randomly generate a game between the different options. 

    {
        //create the "Random" instance
        var Random = new Random();
        //Randomly cycle through the 4 options
        var randomCycle = Random.Next(1, 4);
        
        //Create an array so the 4 games can be different options to cycle through
        var result = new int[4];
        int numGuesses = 0;


        result[0] = randomCycle;


        
        return result;
        
    }
}
    
