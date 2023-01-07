using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);

        int guess = 0;

        while (guess != magic_number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magic_number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic_number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }



    }
}