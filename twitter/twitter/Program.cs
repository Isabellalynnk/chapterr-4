using System;

namespace twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry;
            Console.WriteLine("Please enter your message");
            entry = Console.ReadLine();

            if(entry.Length <= 140)
            {
                Console.WriteLine("The length of your message is acceptable");
            }
            else
            {
                Console.WriteLine("Message too long" + entry.Length);
            }

        }
    }
}
