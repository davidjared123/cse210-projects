class Save
{
    public void saveFile(string dir, string add)
    {
        if (File.Exists(dir))
        {
            using (StreamWriter outputFile = File.AppendText(dir))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine(add);
            }
        }
        else
        {
            // Open file
            using (StreamWriter outputFile = new StreamWriter(dir))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine("This will be the first line in the file.");

                // You can use the $ and include variables just like with Console.WriteLine
                string color = "Yellow";
                outputFile.WriteLine($"My favorite color is {color}");
            }
        }
    }
}