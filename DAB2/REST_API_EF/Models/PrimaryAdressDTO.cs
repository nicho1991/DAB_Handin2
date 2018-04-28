using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST_API_EF.Models
{
    public class PrimaryAdressDTO
    {
        public int Id { get; set; }

        public Adress PrimaryAdressAdress { get; set; }

        public PrimaryAdressDTO(Adress adr)
        {
            PrimaryAdressAdress = adr;
        }
    }
}