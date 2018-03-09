using System.Collections;
using System.Collections.Generic;

public class Adress
{
    //public Adress(string streetName, string houseNumber, string zipCode, string cityName)
    //{
    //    StreetName = streetName;
    //    HouseNumber = houseNumber;
    //    ZipCode = zipCode;
    //    CityName = cityName;
    //}
    public int AdressID { get; set; }
    public virtual List<TypeOfAdress> TypeOfAdress { get; set; }
    public string CityName { get; set; }
    public string HouseNumber { get; set; }
    public string StreetName { get; set; }
    public string ZipCode { get; set; }
}