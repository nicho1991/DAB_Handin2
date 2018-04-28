using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST_API_EF.Models
{
    public class SecondaryAdressDTO
    {
        public int Id { get; set; }

        public Adress SecondaryAdressAdress { get; set; }

        public SecondaryAdressDTO(Adress adr)
        {
            SecondaryAdressAdress = adr;
        }
    }
}