using System;

namespace ageInsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterAge;
            string result = null;
            Console.WriteLine("Please enter an age so that i may make fun of you!!");
            Console.WriteLine("If you call me a boomer you might die of old age.");
            enterAge = Convert.ToInt32(Console.ReadLine());

            if (enterAge <= 12)
            {
                result = "You are just a young punl.";
            }
            else if (enterAge >12 && enterAge <= 17)
            {
                result = "Your generation is the problem";
            }
            else if (enterAge > 17 && enterAge <= 25)
            {
                result = " Get a jobe and pay somke taxes";
            }
            else if (enterAge > 18 && enterAge <= 25)
            {
                result = "Stop complaining you're not too old yet!";
            }
            else if (enterAge > 26 && enterAge <= 35)
            {

                result = "Don't statr forgetting things now!";
            }
            else if (enterAge > 36 && enterAge <= 45)
            {
                result = "Wow getting them grey hairs now!";
            }
            else if (enterAge > 45 && enterAge <= 54)
            {
                result = "Wow you're getting close to retiring";
            }
            else if (enterAge > 55 && enterAge <= 62)
            {
                result = " Start planning your funeral, the tock is ticking";
            }
            else if (enterAge > 62)
            {
                result = "What ever happened to that old fart?";
            }

                Console.WriteLine(result);
        }
    }
}
