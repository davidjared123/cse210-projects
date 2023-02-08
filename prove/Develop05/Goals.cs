class Goals
{
    protected List<string> _goalsList;
    protected string _name;
    protected string _description;
    protected int _points;

    protected bool _compelted;
    protected string _response;
    protected string _message = ("\nThe Types of Goals are: " + "\n    1. Simple Goal" + "\n    2. Eternal Goal" + "\n    3. Checklist Goal" + "\nWhich type of goal would you like to create? ");

    public void SetMessage(string message)
    {
        _message = message;
    }
    public void displayMenu()
    {
        Menu menu = new Menu();
        menu.SetMenu(_message);
        menu.DisplayMenu();
    }

    public void GoalsRun()
    {
        displayMenu();
        _response = Console.ReadLine();
        switch (_response)
        {
            case "1":
                SimpleGoals simpleGoals = new SimpleGoals();
                simpleGoals.SimpleGoalsRun();
                break;
            case "2":

                break;
            case "3":

                break;
        }
    }

    public string GetGoalDirectory()
    {
        return Directory.GetCurrentDirectory() + "\\Files\\" + Console.ReadLine();
    }

    public void SetGoalsList(string add)
    {
        _goalsList.Add(add);
    }


    public void GetGoalsList()
    {
        foreach (var item in _goalsList)
        {
            Console.WriteLine(item);
        }

    }

}