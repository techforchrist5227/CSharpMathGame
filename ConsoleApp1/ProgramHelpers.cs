internal static class ProgramHelpers
{

    void AdditionGame(string message)
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

        for (int i = 0; i < 3; i++)
        {

            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);
            numIncorrGuesses = 0;
            var score = 0;
            Console.WriteLine($@" What is {firstNumber} + {secondNumber} = ?");
            string guess = Console.ReadLine();

            int guessToNum = int.Parse(guess);
            numTurns++;








            if (guessToNum == firstNumber + secondNumber)
            {

                Console.WriteLine("You are correct!");

                score++;

            }
            else
            {

                Console.WriteLine("Your answer was incorrect");




            }

            if (i == 4)
            {
                Console.WriteLine($"Game over. Your final score is : {score}");
            }





        }




    }

    void Division(string message)
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

        for (int i = 0; i < 3; i++)
        {

            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);
            numIncorrGuesses = 0;
            var score = 0;
            Console.WriteLine($@" What is {firstNumber} / {secondNumber} = ?");
            string guess = Console.ReadLine();

            int guessToNum = int.Parse(guess);
            numTurns++;








            if (guessToNum == firstNumber / secondNumber)
            {

                Console.WriteLine("You are correct!");

                score++;

            }
            else
            {

                Console.WriteLine("Your answer was incorrect");




            }

            if (i == 4)
            {
                Console.WriteLine($"Game over. Your final score is : {score}");
            }


        }

         void Multiplication(string message)
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

            for (int i = 0; i < 3; i++)
            {

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                numIncorrGuesses = 0;
                var score = 0;
                Console.WriteLine($@" What is {firstNumber} * {secondNumber} = ?");
                string guess = Console.ReadLine();

                int guessToNum = int.Parse(guess);
                numTurns++;








                if (guessToNum == firstNumber * secondNumber)
                {

                    Console.WriteLine("You are correct!");

                    score++;

                }
                else
                {

                    Console.WriteLine("Your answer was incorrect");




                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is : {score}");
                }


            }

            static void RandomChoiceOption()
            {
                Console.WriteLine("You have chosen the Random Mix!!!"); ;
            }

            static void Subtraction()
            {
                Console.WriteLine("You have chosen Subtraction.");
            }
        }
    }
}