using System;
using System.Collections.Generic;

namespace AtmProject
{
    class ATMProgram : UserInformation
    {
        private static object newUser;
        RequestPin requestPIN = new RequestPin();
        UserInformation.userInformation cardHolder = new UserInformation.userInformation();


        static void Main(string[] args)
        {

            Console.Title = "AtmProject";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Please Input your Pin");

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

            void withdrawFunds(UserInformation cardHolders)
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

            void balance(UserInformation cardHolders)
            {
                UserInformation.userInformation userInformation = new UserInformation.userInformation();
                UserInformation.userInformation cardHolder = new UserInformation.userInformation();
                Console.WriteLine(cardHolder.balance);
            }

            List<UserInformation.userInformation> cardHolders = new List<UserInformation.userInformation>();
            cardHolders.Add(new UserInformation.userInformation(1354, "934583449834", "John", "129 Center Street, Munich", "(903)342-2133", 234));
            cardHolders.Add(new UserInformation.userInformation(1234, "945869385968", "Mary", "456 Baker Street, London", "(898)902-2039", 30));
            cardHolders.Add(new UserInformation.userInformation(4678, "039345969346", "Harry", "192 Easter Street, Israel", "(684)342-0233", 200));
            cardHolders.Add(new UserInformation.userInformation(6035, "123563259603", "Sue", "290 South Street, Atlanta", "(510)090-3453", 209345));
            cardHolders.Add(new UserInformation.userInformation(0395, "352626039786", "Larry", "194 Pongo Street, Boston", "(320)132-6743", 10495));

            Console.WriteLine("Welcome to Sisu ATM");
            Console.WriteLine("Please Insert your card");
            while (true)
            {
                try
                {
                    UserInformation.userInformation newUser = new UserInformation.userInformation();
                    string cardNum = "";
                    cardNum = Console.ReadLine();
                    string cardHolderCardNumber = Convert.ToString(newUser.cardNumber);
                    cardHolders = userInformation.FirstOrDefault(a => cardHolderCardNumber == cardNum);
                    if (cardHolders != null) { break; }
                    else
                    {
                        Console.WriteLine("Card is not recognized. Please try another.");
                    }
                }
                catch
                {
                    Console.WriteLine("Card is not recognized. Please try another.");
                }

                Console.WriteLine("Please enter your pin:");



                while (true)
                {
                    try
                    {
                        UserInformation.userInformation newUser = new userInformation();
                        int userPin = 0;
                        userPin = Int32.Parse(Console.ReadLine());
                        string cardHolderPinNumber = Convert.ToString(newUser.accountPin);
                        if (newUser.accountPin == userPin) { break; }
                        else
                        {
                            Console.WriteLine("Incorrect Pin Number. Please try again.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Incorrect Pin Number. Please try again.");
                    }

                }
                plist.foreach 
                Console.WriteLine(.userName);



                }
            }
        }
    }
}
