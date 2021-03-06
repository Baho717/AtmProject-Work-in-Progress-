using System;
using System.Collections.Generic;

namespace AtmProject
{
    public class UserInformation
    {
        public class userInformation
        {
            public int accountPin { get; set; }
            public string cardNumber { get; set; }
            public string userName { get; set; }
            public string userAddress { get; set; }
            public string phoneNumber { get; set; }
            public double balance { get; set; }

            public userInformation(int AccountPin, string CardNumber, string UserName, string UserAddress, string PhoneNumber, double Balance)
            {
                this.accountPin = AccountPin;
                this.cardNumber = CardNumber;
                this.userName = UserName;
                this.userAddress = UserAddress;
                this.phoneNumber = PhoneNumber;
                this.balance = Balance;

        }
        public userInformation()
            {
                this.accountPin = int.Parse(string.Empty);
                this.cardNumber = string.Empty;
                this.userName = string.Empty;
                this.userAddress = string.Empty;
                this.phoneNumber = string.Empty;
                this.balance = double.Parse(string.Empty);

            }

            internal static List<userInformation> FirstOrDefault(Func<object, bool> p)
            {
                throw new NotImplementedException();
            }
        }
    }
}
