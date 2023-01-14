namespace Menu
{
    public class Journal
    {
        List<string> questions = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
            };



        public void writeJournal()
        {
            Random rnd = new Random();
            int index = rnd.Next(questions.Count);
            Console.WriteLine(questions[index]);
            string response = Console.ReadLine();
        }

        public static void display()
        {

        }
    }
}