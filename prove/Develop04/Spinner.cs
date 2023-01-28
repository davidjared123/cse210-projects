using System.Diagnostics;
using System.Threading;
class Spinner
{
    private int SpinnerCount = 0;

    public void Start(int time)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        // Console.WriteLine("Get ready...");

        while (stopwatch.ElapsedMilliseconds / 1000 < time)
        {
            SpinnerCount++;
            switch (SpinnerCount % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(340);
        }
        Console.Write(" ");
    }
}