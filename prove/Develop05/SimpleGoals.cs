using System.IO;
class SimpleGoals : Goals
{
    public void SimpleGoalsRun()
    {
        SetMessage("What is the name of your goal? ");
        displayMenu();
        _name = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.WriteLine("What is the amount of associated with this goal? ");
        _points = Convert.ToInt16(Console.ReadLine());


        Console.Write(convertToString());
        string dir = Directory.GetCurrentDirectory() + "\\Files\\" + "prueba.txt";

        Save save = new Save();
        save.saveFile(dir, convertToString());
        _goalsList.Add(convertToString());
        GetGoalsList();


    }

    public string convertToString()
    {
        return string.Format("[{0}] {1} {2}", ((_compelted == false) ? " " : "X"), _name, _description);
    }
}