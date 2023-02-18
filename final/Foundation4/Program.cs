using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("April 24, 2023 Runing", 30, 3);
        Bicycles bicycles = new Bicycles(40, "December 21, 2022 Bicycles", 20);
        Swimming swimming = new Swimming("February 20, 2023 Swimming", 15, 30);

        activities.Add(running);
        activities.Add(bicycles);
        activities.Add(swimming);

        foreach (Activity item in activities)
        {
            Console.WriteLine(item.GetSumary());
        }
    }
}