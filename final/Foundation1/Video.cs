class Video
{
    private string _title;
    private string _author;
    private int _length;

    public Video()
    {
        _title = "No title";
        _author = "No author";
        _length = 0;
    }
    public Video(string title)
    {
        _title = title;
        _author = "No author";
        _length = 0;
    }

    public Video(string title, string author)
    {
        _title = title;
        _author = author;
        _length = 0;
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string toString()
    {
        return string.Format("Title: {0}, Author: {1}, Duration: {2}sec.", _title, _author, _length);
    }

}