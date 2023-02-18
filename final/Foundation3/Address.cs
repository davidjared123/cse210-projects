public class Address : Event
{
    private string _address;
    public Address() : base()
    { }

    public Address(string address) : base()
    {
        _address = address;
    }

    public string GetAddress { get => _address; set => _address = value; }
}