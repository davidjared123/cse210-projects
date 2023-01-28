using System.Diagnostics;
using System.Threading;

class BreathingActivity : Activity
{
    // private string _alternativeMessage = "";
    //GETTER
    Spinner spinner = new Spinner();
    public int _time;
    public void GetMenu()
    {
        Console.WriteLine("\n Welcome to the Breathing Activity." + "\n" +
        "\nThis activity will help you relax by walking your through breathing in and slowly. Clear your mind and focus on your breathinh." + "\n");
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
        Breathing(_time);
    }

    public void Breathing(int time)
    {
        // Console.WriteLine($"This is the TIME: {time}");
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        int count = time;
        while (stopwatch.ElapsedMilliseconds / 1000 < time)
        {
            Console.Write("\nBreathe in: ");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
            Console.Write("\nBreathe out: ");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }

            Console.WriteLine(" ");
        }
    }


}