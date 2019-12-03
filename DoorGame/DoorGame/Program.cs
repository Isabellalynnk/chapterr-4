using System;

namespace DoorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry;
            Console.WriteLine("Pick a door 1, 2, 03");
            userEntry = Convert.ToInt32(Console.ReadLine());
            
            if (userEntry == 1)
            {
                Console.WriteLine("Congradulations! You get awarded a teddy sloth");
            }
            elseif(userEntry == 2)
            {

            }

        }
    }
}
