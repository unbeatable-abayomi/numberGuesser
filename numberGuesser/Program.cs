using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//NameSpace
namespace numberGuesser
{
    //main class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            //string name = "abayomi";
            //int age = 20;

            //Console.WriteLine(name+" is "+age);
            //Console.WriteLine("{1} is {0}", name,age);

            //Run GetAppInfo Function to get info
            GetAppInfo();

            GreetUser(); //ask for user name then greet  
            while (true) { 
            //init correct number
            //int correctNumber = 7;

            //create a new random object
            Random random = new Random();
            
            //init correct number
            int correctNumber = random.Next(1, 10);

            //init guess var
            int guess = 0;
            Console.WriteLine("Guess a number betwwen 1 and 10");



            //while guess isn't correct'
            while (guess != correctNumber) {
                //get users input
                 string input = Console.ReadLine();

                //make sure its a number
                if (!int.TryParse(input,out guess))
                {
                        //printErrorMessage
                        PrintErrorMessage(ConsoleColor.Red,"Wrong Pls Use an Actual Number!! Try Again");

                    //keep going
                    continue;
                }

                guess = Int32.Parse(input);
                //Match guess to correct number

                if (guess != correctNumber)
                {
                    
                        //printErrorMessage
                        PrintErrorMessage(ConsoleColor.Red, "Wrong Number, pls try again");

                    }

                }
            //sucess message
                PrintErrorMessage(ConsoleColor.Yellow, "You are Correct");
                
                //Ask to play again 
                Console.WriteLine("Play Again? [Y or N]");
               
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        // getAppInfo Functio
        static void GetAppInfo()
        {
            



            //Start Here Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthour = "abayomi igwubor";
            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0} : Version {1} by {2}", appName, appVersion, appAuthour);

            //Reset Text Color
            Console.ResetColor();
        }
        
        //greetUserFunction
        static void GreetUser()
        {
            //Ask user Name
            Console.WriteLine("What is your Name");

            //Get User name
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game....", inputName);
        }

        //printErrorFunction
        static void PrintErrorMessage (ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Tell user its a wrong number
            Console.WriteLine(message);

            //Reset Text Color
            Console.ResetColor();
        }
    }
}
