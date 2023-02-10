using System;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video("The Best title", "David Perez", 60);
        Console.WriteLine(video.toString());

        // getting video info
        Console.Clear();
        Console.WriteLine("What's the title video? ");
        string title = Console.ReadLine();

        Console.WriteLine("What's the Author? ");
        string author = Console.ReadLine();

        Console.WriteLine("What's the duration? (in seconds): ");
        int length = Convert.ToInt16(Console.ReadLine());

        Video video1 = new Video(title, author, length);
        Console.WriteLine(video1.toString());

        Comments comments = new Comments();
        comments.SetComment();

        Console.Clear();
        Console.WriteLine(video1.toString());
        comments.GetComments();

    }
}