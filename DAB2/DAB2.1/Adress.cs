public class Adress
{
    public Adress(string streetName, string houseNumber, string zipCode, string cityName)
    {
        StreetName = streetName;
        HouseNumber = houseNumber;
        ZipCode = zipCode;
        CityName = cityName;
    }

    public string CityName { get; }
    public string HouseNumber { get; set; }
    public string StreetName { get; set; }
    public string ZipCode { get; set; }
}