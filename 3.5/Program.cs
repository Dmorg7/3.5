using System;

namespace _3._5
{
    // author: Benjamin Daniel Morgan
    // date: 11/12/17

    class Program
    {
        static void Main(string[] args)
        {
            askQuestion();
            reAskToPlay();
        }
        static void askQuestion()
        {
            int count = 0;
            string input, name;
            int Answer;

            int n;
            Random rand = new Random();

            Console.Clear();
            Console.WriteLine("Welcome to THE GUESSING GAME");
            Console.WriteLine("Please Enter your Name?");
            name = Console.ReadLine();

            Console.WriteLine(name + ",I am going to pick a number between 1 and 100, and you must try and guess my number?");
            Console.WriteLine("Ready," + name);

            n = rand.Next(100) + 1;

            Console.WriteLine("Ok... have i have picked a number.");
            Console.WriteLine("What is your guess," + name + ":");

            input = Console.ReadLine();
            Answer = Convert.ToInt32(input);

            count++;


            do
            {
                if (Answer > n)
                {
                    Console.WriteLine(input + "is Too High");
                    Console.WriteLine("Please try again. What is my number?" + name);

                    input = Console.ReadLine();
                    Answer = Convert.ToInt32(input);

                    count++;
                }
                if (Answer < n)
                {
                    Console.WriteLine(input + "is Too Small");
                    Console.WriteLine("Please try again. What is my number?" + name);

                    input = Console.ReadLine();
                    Answer = Convert.ToInt32(input);

                    count++;
                }
                if (Answer == n && count < 10 && count > 5)
                {
                    Console.WriteLine("Spot On! That is the correct answer. Well Done!");
                    Console.WriteLine("It took you" + count + "guesses, that is very good!");
                }
                if (Answer == n && count < 5)
                {
                    Console.WriteLine("Wow! That is the correct answer. Very Well Done!");
                    Console.WriteLine("It took you" + count + "guesses, that is fantastic!");
                }
                if (Answer == n && count > 10)
                {
                    Console.WriteLine("Finally! That is the correct answer. Well Done!");
                    Console.WriteLine("It took you" + count + "guesses, you are not very good at this are you?");
                }
            }
            while (Answer != n);

        }
        static void reAskToPlay()
        {
            string input;
            int count2 = 0;

            Console.WriteLine("Would anybody else like to play? Enter Y/N");
            input = Console.ReadLine();

            if(input == "Y")
            {
                askQuestion();
                reAskToPlay();
            }
            if(input == "N")
            {
                Console.WriteLine("Thank you for playing THE GUESSING GAME!");
                Console.WriteLine(count2 + " player(s) have played this game");
            }

            count2++;
        }
    }
}
 