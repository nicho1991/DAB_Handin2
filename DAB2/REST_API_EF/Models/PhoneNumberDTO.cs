using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST_API_EF.Models
{
    public class PhoneNumberDTO
    {

        public int PersonID { get; set; }
        public string Email { get; set; }
        public string FamilyName { get; set; }
        public string Type { get; set; }
        public string GivenName { get; set; }
        public string MiddleName { get; set; }
        public string Phonecompany { get; set; }
        public string Phonenumber { get; set; }
        public string Usage { get; set; }
        public int telephoneId { get; set; }

        public PhoneNumberDTO(Telephone T)
        {
            PersonID = T.PersonRefId;
            Email = T.Person.Email.UniqueEmail;
            FamilyName = T.Person.FamilyName;
            Type = T.Person.PersonType;
            GivenName = T.Person.GivenName;
            MiddleName = T.Person.GivenName;
            Phonenumber = T.TelephoneNumber;
            Phonecompany = T.PhoneCompany;
            Usage = T.UsageOfTlf;
            telephoneId = T.telephoneID;


        }


    }
    }
}