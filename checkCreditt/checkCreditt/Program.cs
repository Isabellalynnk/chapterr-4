using System;

namespace checkCreditt
{
    class Program
    {
        static void Main(string[] args)
        {
            double userCredit;
            string result = null;

            Console.WriteLine("please enter purchase price of the item>>");
            userCredit = Convert.ToInt32(Console.ReadLine());

            if (userCredit >= 5000)
            {
                result = "Error, Looks like your purchase is too big";
            }
            else if (userCredit <= 5000)
            {
                result = "Your purchase has been Approved!!";
            }

            Console.WriteLine(result);
        }
    }
}
