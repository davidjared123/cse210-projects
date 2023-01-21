class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int Number)
    {
        _top = Number;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string get_string()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double get_decimal()
    {
        double num = _top / _bottom;
        return num;
    }
}