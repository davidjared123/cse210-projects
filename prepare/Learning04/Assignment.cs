public class Assignment
{
    protected string _stundentName = "";
    private string _topic = "";

    public string GetStudentName()
    {
        return _stundentName;
    }
    public void SetStudentName(string name)
    {
        _stundentName = name;
    }
    public string GetToppic()
    {
        return _topic;
    }
    public void SetToppic(string topic)
    {
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"Name: {_stundentName}, Topic: {_topic}.";
    }

}