public class Event
{
    protected string _title, _description, _date, _time;
    // private List<Event> standardsDetails = new List<Event>();
    // private List<Event> fullDetails = new List<Event>();
    // private List<string> shortDetails = new List<string>();
    // public List<Event> _standardsDetails { get => standardsDetails; set => standardsDetails = value; }
    // public List<Event> _fullDetails { get => fullDetails; set => fullDetails = value; }
    // public List<string> _shortDetails { get => shortDetails; set => shortDetails = value; }

    public List<string> details = new List<string>();
    public List<string> _details { get => details; set => details = value; }

    public string EventTitle { get => _title; set => _title = value; }
    public string EventDescription { get => _description; set => _description = value; }
    public string EventDate { get => _date; set => _date = value; }
    public string EventTime { get => _time; set => _time = value; }


    public Event()
    {

    }
    public Event(string title, string description, string date, string time)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
    }

    public void DisplayMenu()
    {
        Console.WriteLine("What kind of details do you want to see?: " + "\n    1. Standard" + "\n    2. Full" + "\n    3. Short");
    }

}