using System.Collections.Generic;

public class Adress
{
    public Adress(string streetName, string HouseNumber, string zipCode, string cityName)
    {
        _streetName = streetName;
        _houseNumber = HouseNumber;
        _zipCode = zipCode;
        _cityName = cityName;

    }

    public string _cityName { get; set; }
    public string _houseNumber { get; set; }
    public string _streetName { get; set; }
    public string _zipCode { get; set; }

}