class Menu
{
    public Menu(Reference scriptureReference, ScriptureMemorizer scriptureMemorizer)
    {
        string userInput = "";
        do
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemorizer.toString()));
            Console.WriteLine("Press enter to continue or type 'quit' to finish: \n");
            userInput = Console.ReadLine().ToLower();
            scriptureMemorizer.removeWordsFromText();
        }
        while (userInput != "quit" && scriptureMemorizer.hasWordsLeft() == true);
    }
}