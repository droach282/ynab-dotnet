using System;
using YNAB;

namespace YNAB.Testbed
{
    class Program
    {
        static void Main(string[] args)
        {
            const string _apiKey = "insert your key here";

            var ynab = new YNABClient();

            ynab.SetPersonalToken(_apiKey);

            var user = ynab.GetCurrentUser();

            Console.WriteLine(user.Id);
        }
    }
}
