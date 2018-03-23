using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Adress
{
   // public ICollection<AltAdresse> altAdresser { get; set; } = new List<AltAdresse>();

    public Adress()
    {

    }
    public Adress(string streetName, string houseNumber, string zipCode, string cityName)
    {
        StreetName = streetName;
        HouseNumber = houseNumber;
        ZipCode = zipCode;
        CityName = cityName;
    }
    [Key]
    public int adressID { get; set; }
    public string CityName { get; set; }
    public string HouseNumber { get; set; }
    public string StreetName { get; set; }
    public string ZipCode { get; set; }
}