using System;
using System.Diagnostics;

namespace AtmProject
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            bool keepGoing = true;
            while (keepGoing)
            {
                keepGoing = DisplayMainMenu();

            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Console.WriteLine(" Program Terminated");

        }

        private static bool DisplayMainMenu()
        {

            Console.WriteLine("1. Main Menu");
            Console.WriteLine("2. Input Balance");
            Console.WriteLine("3. Insert Transaction");
            Console.WriteLine("4. Exit");

            var userChoice = Console.ReadKey().KeyChar;
            Console.WriteLine($" You chose {userChoice}");
            Console.WriteLine("");


            UserInformation.userInformation userInformation = new UserInformation.userInformation();

            switch (userChoice)

            {
                case '1':
                    Console.WriteLine("You Have Chosen to Create a User Profile");
                    Console.WriteLine("What is your full name?");
                    var userName = Console.ReadLine();
                    userInformation.userName = (userName);

                    Console.WriteLine("What is your name?");
                    var userPin = Console.ReadLine();
                    userInformation.accountPin = Convert.ToInt32(userPin);


                    break;

                case '2':
                    Console.WriteLine("You Have Chosen to Input Balance");
                    Console.WriteLine("What is your name?");


                    break;

                case '3':
                    Console.WriteLine("You Have Chosen to Insert Transaction");
                    Console.WriteLine("What is your name?");


                    break;

                case '4':
                    return false;

                default:
                    Console.WriteLine($"{userChoice} was not valid. Please choose a valid number between 1-4 ");
                    break;



            }
        }
    }
}