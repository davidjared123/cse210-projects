using System.Diagnostics;
using System.Threading;

class listingActivity : Activity
{
    // private string _alternativeMessage = "";
    //GETTER
    Spinner spinner = new Spinner();
    public int _time;
    public void GetMenu()
    {
        Console.WriteLine("\n Welcome to the listing Activity." + "\n" +
        "\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area." + "\n");
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
        listing(_time);
    }

    // private int Count;
    public void listing(int time)
    {
        Console.WriteLine("Get Ready...");
        spinner.Start(3);

        Console.Write("List as many responses you can to the following prompt: " + "\n --- When have you felt the Holy Ghost this month? ---" + "\nYou may begin in: ");
        for (int i = 5; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }

        Console.Clear();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        List<string> list = new List<string>();

        while (stopwatch.ElapsedMilliseconds / 1000 < time)
        {
            Console.Write("> ");
            string addItem = Console.ReadLine();
            list.Add(addItem);
        }
        Console.WriteLine(" ");
        Console.WriteLine("Well done!");
        spinner.Start(3);
        Console.WriteLine($"You have completed another {time} seconds of the listing Activity.");
        spinner.Start(3);
        Console.Clear();
    }


}