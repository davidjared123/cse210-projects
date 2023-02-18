using System;

class Program
{
    static void Main(string[] args)
    {

        Lectures lecture = new Lectures("Programming in the real life", "Is the worldwide gathering Every programmer around the world. Coder share their thinking about programming and theirs experiences", "May 25, 2023", "9:00 AM", "Bill Gates", 5000);
        Address lectureAddress = new Address("Silicon Valley Business Center, San Jose, California");

        Receptions reception = new Receptions("La Flor", "La Flor de Venezuela, is the best place to have your recption", "July 20, 2023", "7:00 pm", "davidjared123@gmail.com");
        Address receptionAddress = new Address("Barquisimeto, Lara, Venezuela.");

        Outdoors outdoor = new Outdoors("Spring Gardeen", "The besto point to recive the life inspiration that you need", "April 24, 2023", "7:00 am - 10:30 am", "Sunny, 50°");
        Address outdoorAddress = new Address("75 w Carlota DR, Spring garden, 41505");

        lecture._details.Add(lecture.ToString());
        reception._details.Add(reception.ToString());
        outdoor._details.Add(outdoor.ToString());

        Event eventM = new Event();
        int response = 0;
        int res = 0;
        List<string> menu = new List<string>()
        {
            "Event Agenda: ",
            "What kind of event do you want to see?: ",
            "   1. Lectures",
            "   2. Receptions",
            "   3. Outdoor",
            "   4. Quit"
        };

        Event eventMain = new Event();

        while (response != 4)
        {
            Console.WriteLine();
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.WriteLine("Selet a choice from menu: ");
            response = int.Parse(Console.ReadLine());
            switch (response)
            {
                case 1:
                    eventM.DisplayMenu();
                    res = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (res)
                    {
                        case 1:
                            lecture.GetStandardDetails(lectureAddress.GetAddress);
                            break;
                        case 2:
                            lecture.GetFullDetails(lectureAddress.GetAddress);
                            break;
                        case 3:
                            lecture.GetShortDetails();
                            break;
                    }
                    break;

                case 2:
                    eventM.DisplayMenu();
                    res = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (res)
                    {
                        case 1:
                            reception.GetStandardDetails(receptionAddress.GetAddress);
                            break;
                        case 2:
                            reception.GetFullDetails(receptionAddress.GetAddress);
                            break;
                        case 3:
                            reception.GetShortDetails();
                            break;
                    }
                    break;

                case 3:
                    eventM.DisplayMenu();
                    res = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (res)
                    {
                        case 1:
                            outdoor.GetStandardDetails(outdoorAddress.GetAddress);
                            break;
                        case 2:
                            outdoor.GetFullDetails(outdoorAddress.GetAddress);
                            break;
                        case 3:
                            outdoor.GetShortDetails();
                            break;
                    }
                    break;
            }
        }
    }
}