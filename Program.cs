using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;


namespace ConsoleApp1 


{

    public class Program
    {
        //access modifier(public), static , return type (void),  name, param list(param1,param2)

        public static void Main(string[] args)
        {


            var Date = DateTime.UtcNow;

            Console.WriteLine($"Please type in your name : \n\n");

            string name = Console.ReadLine();

            Console.WriteLine("How old are you?");

            string age = Console.ReadLine();

            
            

            int ageToInt = int.Parse(age);



            Console.WriteLine("Would you like to play the math game?");

            string playerChoice = Console.ReadLine();

            playerChoice.ToUpper();

            if (playerChoice == "yes" || playerChoice == "y")
            {
                Choice_Menu(Date, name);

                Console.WriteLine("-------------------------------------\n\n");
            }
            else
            {
                Environment.Exit(1);
            }




        }

        public static void Choice_Menu(DateTime Date, string name)
        {


            bool isGameOn = true;

           



            do
            {
                

                Console.Clear();
                
                Console.WriteLine($@"  Hello {name.ToUpper()} {Date} , welcome to the Math game!  Which game would you like to play?
                A - Addition
                S - Subtraction
                M - Multiplication
                D - Division
                R - Random / Mix
                Q - Quit
                
                    
                                
                ");

                string gameChoice = Console.ReadLine();

                gameChoice.ToUpper().ToCharArray();


                Console.WriteLine("\n");


                switch (gameChoice.Trim().ToLower())
                {
                    case "a":
                        ProgramHelpers.AdditionGame("You have chosen the Addition game!");
                        break;
                    case "s":
                        ProgramHelpers.Subtraction("You have chosen the subtraction game");
                        break;
                    case "m":
                        ProgramHelpers.Multiplication("You have chosen the multiplication game!");
                        break;
                    case "d":
                        ProgramHelpers.Division("You have chosen the division game!");
                        break;
                    case "r":
                        ProgramHelpers.RandomChoiceOption("You have chosen the random mix!!!");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye for now!");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        Environment.Exit(1);
                        break;
                }
            } while (isGameOn);


            
        }
    }












}