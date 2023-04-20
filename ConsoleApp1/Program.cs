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

            Choice_Menu(Date, name);

            Console.WriteLine("-------------------------------------\n\n");

            

            int ageToInt = int.Parse(age);








        }

        private static void Choice_Menu(DateTime Date, string name)
        {
            Console.WriteLine($@"  Hello {name.ToUpper()} , welcome to the Math game!  Which game would you like to play?
                A - Addition
                S - Subtraction
                M - Multiplication
                D - Division
                U - Random / Mix
                Q - FAAAAIIIIILURE / Disgrace Da Famiry (Quit)
                
                    {Date}
                                
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
                    ProgramHelpers.Subtraction();
                    break;
                case "m":
                    ProgramHelpers.Multiplication();
                    break;
                case "d":
                    ProgramHelpers.Division();
                    break;
                case "u":
                    ProgramHelpers.RandomChoiceOption();
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
        }
    }












}