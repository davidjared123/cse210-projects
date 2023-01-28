using System.Diagnostics;
using System.Threading;

class ReflectingActivity : Activity
{
    // private string _alternativeMessage = "";
    //GETTER
    Spinner spinner = new Spinner();
    public int _time;
    public void GetMenu()
    {
        Console.WriteLine("\n Welcome to the Reflecting Activity." + "\n" +
        "\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life." + "\n");
        Console.WriteLine(" ");
        Console.Write("How long, in seconds, would you like for your session? ");
        int time = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"Duration: {time}");

        _time = time;
    }

    public void Start()
    {
        GetMenu();
        spinner.Start(3);
        Reflecting(_time);
    }

    private int Count;
    public void Reflecting(int time)
    {
        Console.WriteLine("\n Consider the following prompt:" + "\n --- Think of a time when you did something really difficult. ---" + "\n When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("\n Now ponder on each of the following questions as they related to this experience." + "\n You may begin in: ");
        for (int i = 5; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }

        Console.Clear();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while (stopwatch.ElapsedMilliseconds / 1000 < time)
        {
            Count++;
            switch (Count % 2)
            {
                case 0:
                    Console.WriteLine("\n> How did you feel when it was complete?"); spinner.Start(time / 2); break;
                case 1:
                    Console.WriteLine("> What is your favorite thing about this experience?"); spinner.Start(time / 2); break;
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Well done!");
        spinner.Start(3);
        Console.WriteLine($"You have completed another {time} seconds of the Reflecting Activity.");
        spinner.Start(3);
        Console.Clear();
    }


}