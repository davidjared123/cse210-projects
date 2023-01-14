using System.Text;

namespace Menu
{
    public class Journal
    {
        // public List<string> local_journal_storage = new List<string>();
        string filepath = "c:\\temp\\journal.csv";
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
            string _response = Console.ReadLine();
            // save the user response

            Journal j = new Journal();
            j.write(_response);

        }

        public static void display()
        {

        }

        public void write(string resp)
        {
            StringBuilder builder = new StringBuilder();
            DateTime date = DateTime.Now;

            string newDate = date.ToString("MM/dd/yyyy");
            string user_response = resp;

            builder.AppendLine(string.Format("{0},{1}", newDate, user_response));

            File.AppendAllText(filepath, builder.ToString());

            // saving in a local storage also
            // local_journal_storage.Append($"{newDate}: {user_response}");
        }

        public void read()
        {
            StreamReader streamReader = new StreamReader(filepath);

            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine();
                var values = line.Split(",");

                Console.WriteLine("{0} - {1}", values);
            }
            streamReader.Close();
        }

        public void save_txt()
        {
            Console.WriteLine("Please enter a name: example.txt ");
            string new_path = Console.ReadLine();


            StreamReader streamReader = new StreamReader(filepath);

            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine();
                var values = line.Split(",");

                Console.WriteLine("{0} - {1}", values);
                // values[0].Append()
                StringBuilder builder = new StringBuilder();

                // DateTime date = DateTime.Now;
                // string lastDate = date.ToString("MM/dd/yyyy");

                builder.AppendLine(string.Format("{0} - {1}", values));
                File.AppendAllText($@"c:\\temp\\{new_path}", builder.ToString());
            }
            streamReader.Close();
        }

        public void load()
        {
            Console.WriteLine("Please enter a name: example.txt ");
            string new_path = Console.ReadLine();
            StreamReader streamReader = new StreamReader($@"c:\\temp\\{new_path}");

            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine();
                var values = line.Split(",");
                Console.WriteLine("{0}", values[0]);
            }
            streamReader.Close();
        }
    }
}