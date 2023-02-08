class Menu
{
    private string _mainMenu = ("\nMenu Options: " + "\n    1. Create New Goal" + "\n    2. List Goals" + "\n    3. Save New Goals" + "\n    4. Load New Goals" + "\n    5. Record Event" + "\n    6. Quit" + "\nSelect a choice from the menu: ");

    private string _goalsMenu = ("\nThe Types of Goals are: " + "\n    1. Simple Goal" + "\n    2. Eternal Goal" + "\n    3. Checklist Goal" + "\nWhich type of goal would you like to create? ");

    private string _menu;

    public void SetMenu(string menu)
    {
        _menu = menu;
    }
    public void DisplayMenu()
    {
        Console.Write(_menu);
    }

    private void NewGoalsMenu()
    {
        Console.Write(_goalsMenu);
    }

    public void DisplayMainMenu()
    {
        Console.Write(_mainMenu);
    }
}