using System;

namespace selection_exer
{
    class Program
    {
        static void Main(string[] args)
        {
            int favNum = 69;

            Console.WriteLine("Can you guess my favorite number?");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favNum)
            {
                Console.WriteLine("Nope! Too Low!");
            }
            else if (userGuess > favNum)
            {
                Console.WriteLine("Sorry! Too High!");
            }
            else if (userGuess == favNum)
            {
                Console.WriteLine("Niiice!! You Got It!!");
            }
            else
            {
                Console.WriteLine("Ah Nevermind!");
            }

            Console.WriteLine("What was your favorite subject in school?");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "math":
                    Console.WriteLine("Mine too!");
                    break;
                case "english":
                    Console.WriteLine("Not my favorite but not bad.");
                    break;
                case "history":
                    Console.WriteLine("I enjoy history but not my favorite.");
                    break;
                case "science":
                    Console.WriteLine("Science is awesome but not my favorite.");
                    break;
                default:
                    Console.WriteLine("Never heard of it.");
                    break;
            }
        }
    }
}
