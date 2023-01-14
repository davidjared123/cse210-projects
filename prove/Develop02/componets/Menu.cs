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

                response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        Journal j = new Journal();
                        j.writeJournal();
                        break;
                    case "2":
                        Console.WriteLine("Display");
                        break;
                    case "3":
                        Console.WriteLine("Load");
                        break;
                    case "4":
                        Console.WriteLine("Save");
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
