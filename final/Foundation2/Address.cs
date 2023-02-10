class Address
{
    private string _street;
    private string _city;
    private string _state_province;
    private string _country;

    public bool inUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void setAddress(string street, string city, string state_province, string country)
    {
        _street = street;
        _city = city;
        _state_province = state_province;
        _country = country;
    }

    public string getAddress()
    {
        return string.Format("street: {0}, city: {1}, state or province: {2}, country: {3}", _street, _city, _state_province, _country);
    }
}