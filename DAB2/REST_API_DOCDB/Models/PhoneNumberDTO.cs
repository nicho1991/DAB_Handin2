using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST_API_EF.Models
{
    public class PhoneNumberDTO
    {

        public int PersonID { get; set; }
        public string Phonecompany { get; set; }
        public string Phonenumber { get; set; }
        public string Usage { get; set; }
        public int telephoneId { get; set; }

        public PhoneNumberDTO(Telephone T)
        {
            PersonID = T.PersonRefId;
            Phonecompany = T.PhoneCompany;
            Phonenumber = T.TelephoneNumber;
            Usage = T.UsageOfTlf;
            telephoneId = T.telephoneID;

        }

    }
    }
