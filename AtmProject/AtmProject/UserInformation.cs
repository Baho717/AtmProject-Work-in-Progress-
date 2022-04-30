using System;
namespace AtmProject
{
    public class UserInformation
    {
        public class UserInformation
        {
            public double accountBalance { get; set; }
            public string userName { get; set; }
            public string userAddress { get; set; }
            public string phoneNumber { get; set; }

            public UserInformation(double AccountBalance, string UserName, string UserAddress, string PhoneNumber)
            {
                this.userName = UserName;
                this.userAddress = UserAddress;
                this.accountBalance = AccountBalance;
                this.phoneNumber = PhoneNumber;
            }
            public UserInformation()
            {
                this.userName = string.Empty;
            }
        }
    }
}
