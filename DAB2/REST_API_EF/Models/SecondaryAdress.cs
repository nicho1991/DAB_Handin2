using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST_API_EF.Models
{
    public class SecondaryAdressDTO
    {
        public int Id { get; set; }

        public string cityname { get; set; }

        public string housenumber { get; set; }

        public string streetname { get; set; }

        public string zipcode { get; set; }

        public SecondaryAdressDTO(Adress adr)
        {
            Id = adr.adressID;
            cityname = adr.CityName;
            housenumber = adr.HouseNumber;
            streetname = adr.StreetName;
            zipcode = adr.ZipCode;
        }
    }
}
