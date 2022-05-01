using System;
using System.Collections.Generic;

namespace AtmProject
{
    class ATMProgram: UserInformation 
    {
        RequestPin requestPIN = new RequestPin();
        UserInformation.userInformation cardHolder = new UserInformation.userInformation();


        static void Main(string[] args)
        {

            Console.Title = "AtmProject";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Please Input your Pin");

            Console.WriteLine($"Your pin is: {pin}");

            Console.ReadKey();



            bool keepGoing = true;
            while (keepGoing)
            {
                keepGoing = MainMenu();
            }
            Console.WriteLine(" Press Any Key to Exit!");
            Console.ReadKey();
            Console.WriteLine(" Program Exited");

            static bool MainMenu(List<UserInformation.userInformation> plist)
            {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Balance");
                Console.WriteLine("4. Exit");
            }


            void addFunds(UserInformation cardHolders)
            {
                UserInformation.userInformation userInformation = new UserInformation.userInformation();
                UserInformation.userInformation cardHolder = new UserInformation.userInformation();

                Console.WriteLine("How Much Would You Like to Deposit funds? ");
                var userInput = Console.ReadKey().KeyChar;
                double deposit = Convert.ToChar(userInput);
                cardHolder.balance = deposit; 
                
                Console.WriteLine($"Thank you for your deposite. Your deposit has been added you your account.");
            }

            void withdrawFunds (UserInformation cardHolders)
             {
                UserInformation.userInformation userInformation = new UserInformation.userInformation();
                UserInformation.userInformation cardHolder = new UserInformation.userInformation();
                Console.WriteLine("How Much Would You Like to Withdraw? ");
                var userInput = Console.ReadKey().KeyChar;
                double withdraw = Convert.ToChar(userInput);
                if (cardHolder.balance > withdraw)
                {
                    Console.WriteLine("Insufficient Funds.");
                }
                else
                {
                    double updateBalance = cardHolder.balance - withdraw;

                    Console.WriteLine($"Thank you. Your Account Has Been Updated.Your current balance is {updateBalance}");
                }
             }

            void balance (UserInformation cardHolders)
            {
                UserInformation.userInformation userInformation = new UserInformation.userInformation();
                UserInformation.userInformation cardHolder = new UserInformation.userInformation();
                Console.WriteLine(cardHolder.balance);
            }

            List<UserInformation.userInformation> cardHolders = new List<UserInformation.userInformation>();
            cardHolders.Add(new UserInformation.userInformation(1354, "934583449834","John", "129 Center Street, Munich","(903)342-2133", 234));
            cardHolders.Add(new UserInformation.userInformation(1234, "945869385968", "Mary", "456 Baker Street, London", "(898)902-2039", 30));
            cardHolders.Add(new UserInformation.userInformation(4678, "039345969346", "Harry", "192 Easter Street, Israel", "(684)342-0233", 200));
            cardHolders.Add(new UserInformation.userInformation(6035, "123563259603", "Sue", "290 South Street, Atlanta", "(510)090-3453", 209345));
            cardHolders.Add(new UserInformation.userInformation(0395, "352626039786", "Larry", "194 Pongo Street, Boston", "(320)132-6743", 10495));

            Console.WriteLine("Welcome to Sisu ATM");
            Console.WriteLine("Please Insert your card");
            UserInformation.userInformation cardHolder;

            while(true)
            {
                try
                {
                    UserInformation.userInformation newUser = new UserInformation.userInformation();
                    string cardNum = "";
                    cardNum = Console.ReadLine();
                    string cardHolderPin = Convert.ToString(newUser.accountPin);
                    cardHolders = userInformation.FirstOrDefault(a => cardHolderPin == cardNum);

                }
                catch
                {
                    Console.WriteLine("Wrong Pin. Please try again.");

                }
            }
        }
    }
}
