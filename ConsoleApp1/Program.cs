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







            if (gameChoice.Trim() == "a" || gameChoice.Trim() == "A")
            {
                AdditionGame("You have chosen the Addition game!");
            } 
            else if(gameChoice.Trim() == "s" || gameChoice.Trim() == "S")
            {
                Subtraction();
                
            }
            else if (gameChoice.Trim() == "m" || gameChoice.Trim() == "M")
            {
                Multiplication();
            }
            else if (gameChoice.Trim() == "d" || gameChoice.Trim() == "D")
            {
                Division();
            }
            else if (gameChoice.Trim() == "u" || gameChoice.Trim() == "U")
            {
                RandomChoiceOption();
            }
            else if (gameChoice.Trim() =="q" || gameChoice.Trim() == "Q") 
            {
                Console.WriteLine("Goodbye for now!");
                Environment.Exit(1);
            } 
            else
            {
                Console.WriteLine("Invalid selection!");
                Environment.Exit(1);
            }



           

            

            Console.WriteLine("-------------------------------------\n\n");

            Console.WriteLine("How old are you?");

            string age = Console.ReadLine();

            int ageToInt = int.Parse(age);


            


           
            
            
        }


        public static void RandomChoiceOption()
        {
            Console.WriteLine("You have chosen the Random Mix!!!"); ;
        }

        public static void Division()
        {
            Console.WriteLine("You have chosen Division"); ;
        }

        public static void Multiplication()
        {
            Console.WriteLine("You have chosen Multiplication"); ;
        }

        public static void Subtraction()
        {
            Console.WriteLine("You have chosen Subtraction.");
        }

        public static void AdditionGame(string message)
        {
            Console.WriteLine(message);



        }

        



       

    }
        

        


        


        
        


    }