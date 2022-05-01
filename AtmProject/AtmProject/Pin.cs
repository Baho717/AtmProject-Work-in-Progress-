using System;
using System.Text;

namespace AtmProject
{
    public class RequestPin
    {
        private static string RequestPIN()
        {
            StringBuilder sB = new StringBuilder();
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);

                if (!char.IsControl(keyInfo.KeyChar))
                {
                    sB.Append(keyInfo.KeyChar);
                    Console.Write("*");

                }
            } while (keyInfo.Key != ConsoleKey.Enter);

            {
                return sB.ToString();
            }

            void deposit (user)
        }
    }
}
