class Menu
{
    public static void displayMenu()
    {
        Message message = new Message();
        String response = null;

        message.SetMessage("\n Menu Options:" +
    "\n     1. Start breathing activity" +
    "\n     2. Start reflecting activity" +
    "\n     3. Start listing activity" +
    "\n     4. quit" +
    "\n Select a choice from the menu: ");
        do
        {
            Console.WriteLine(message.GetMessage());

            response = Console.ReadLine();
            switch (response)
            {
                case "1":


                    BreathingActivity activity = new BreathingActivity();
                    // string message, string description, string endingMessage
                    activity.SetActivityData("Message", "String", "Ending Message");
                    activity.Start();
                    // journal.writeJournal();
                    break;
                case "2":
                    ReflectingActivity act2 = new ReflectingActivity();
                    act2.SetActivityData("Message", "String", "Ending Message");
                    act2.Start();
                    // journal.read();
                    break;
                case "3":

                    listingActivity act3 = new listingActivity();
                    act3.SetActivityData("Message", "String", "Ending Message");
                    act3.Start();
                    break;
                case "4":
                    // journal.save_txt();
                    break;
                default:
                    Console.WriteLine("Please select a valid option");
                    break;
            }
        } while (response != "4");
    }
}