class Comments
{
    private List<string> _comments_list = new List<string>();

    public void GetComments()
    {
        int index = 0;
        // foreach (var item in _comments_list)
        // {
        //     index += 1;
        //     string comment = string.Format("Comment {0}: {1}", index, item);
        //     Console.WriteLine(comment);
        // }

        foreach (string item in _comments_list)
        {
            index += 1;
            string comment = string.Format("Comment {0}: {1}", index, item);
            Console.WriteLine(comment);
        }
    }

    public void SetComment()
    {

        string res = null;
        do
        {
            Console.WriteLine("Would you like Write a Comment: (y/n) ");
            res = Console.ReadLine();
            if (res == "y")
            {
                Console.WriteLine("What's your comment? ");
                string response = Console.ReadLine();
                _comments_list.Add(response);
            }

        } while (res != "n");

        // GetComments();
    }
}