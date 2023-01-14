namespace Menu
{
    public class Entry
    {
        public static void display()
        {
            String response = null;
            do
            {
                Console.WriteLine("\n Please select one of the following choices:" +
        "\n 1. Write" +
        "\n 2. Display" +
        "\n 3. Load" +
        "\n 4. Save" +
        "\n 5. Quit");
                Journal journal = new Journal();
                response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        journal.writeJournal();
                        break;
                    case "2":
                        journal.read();
                        break;
                    case "3":
                        journal.load();
                        break;
                    case "4":
                        journal.save_txt();
                        break;
                    case "5":
                        Console.WriteLine("Quit");
                        break;
                    default:
                        Console.WriteLine("Please select a valid option");
                        break;
                }
            } while (response != "5");
        }


    }
}
