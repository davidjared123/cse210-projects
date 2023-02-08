using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        string _menuSelection = null;
        do
        {
            menu.DisplayMainMenu();
            _menuSelection = Console.ReadLine();

            switch (_menuSelection)
            {
                case "1":
                    Goals goals = new Goals();
                    goals.GoalsRun();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;

            }
        } while (_menuSelection != "6");
    }
}