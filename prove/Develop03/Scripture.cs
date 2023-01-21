class Scripture
{
    private string scriptureText;

    private Reference scriptureRef;

    public Scripture(Reference _scriptureRef, string _scriptureText)
    {
        scriptureRef = _scriptureRef;
        scriptureText = _scriptureText;
    }

    public string toString()
    {
        return string.Format("{0}", scriptureText);
    }
}