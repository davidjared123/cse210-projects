class Activity
{
    protected string _message = "";
    protected string _description = "";
    // protected int _duration = 0;
    protected string _endingMessage = "";

    // Returning the Getters
    public string GetMessage()
    {
        return _message;
    }
    public string GetDescription()
    {
        return _description;
    }
    // public int GetDuration()
    // {
    //     return _duration;
    // }
    public string GetEndingMessage()
    {
        return _endingMessage;
    }

    // Set this Activity data (Setters)
    public void SetActivityData(string message, string description, string endingMessage)
    {
        _message = message;
        _description = description;
        // _duration = duration;
        _endingMessage = endingMessage;
    }


}