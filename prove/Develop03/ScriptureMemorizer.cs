class ScriptureMemorizer
{
    private Scripture scripture;
    private List<string> scriptureList;

    public ScriptureMemorizer(Scripture _scripture)
    {
        scripture = _scripture;
        scriptureList = new List<string>();
        convertTextToList();
    }

    private void convertTextToList()
    {
        scriptureList = scripture.toString().Split(" ").ToList();
    }

    public void removeWordsFromText()
    {
        int wordsToRemove = new Random().Next(2, 4);
        int removedWords = 0;

        do
        {
            int ramdomIndex = new Random().Next(0, scriptureList.Count());

            // TODO only replace woed if it hasn't been replaced yet
            if (scriptureList[ramdomIndex].Contains('_') == false)
            {
                scriptureList[ramdomIndex] = new string('_', scriptureList[ramdomIndex].Count());
                removedWords++;
            }

        } while (removedWords != wordsToRemove);

    }
    public string toString()
    {
        return string.Join(' ', scriptureList);
    }

    public bool hasWordsLeft()
    {
        // This CODE HAS A BUG
        // bool value = false;
        // foreach (string word in scriptureList)
        // {
        //     if (word.Contains(' ') == false)
        //     {
        //         value = true;
        //         break;
        //     }
        // }
        // return value;

        // This CODE RUN better

        bool value = false;

        foreach (string word in scriptureList)
        {
            if (word != "_")
            {
                value = true;
                break;
            }
        }
        return value;
    }
}