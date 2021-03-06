﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using REST_API_EF.Models;

namespace HandIn3._2.Models
{
    public class PersonDTO
    {
        public PersonDTO()
        { }

        public PersonDTO(Person person)
        {
            PersonId = person.PersonID;

            FirstName = person.GivenName;

            MiddleName = person.MiddleName;

            LastName = person.FamilyName;

            Email = person.Email.UniqueEmail;

            PrimaryAddress = new PrimaryAdressDTO(person.altAdresser.First(x => x.TypeOfAdress == "Primary").AlternativeAdress);

            PersonAddresses = new List<SecondaryAdressDTO>();

            PhoneNumbers = new List<PhoneNumberDTO>();

            foreach (AltAdresse pa in person.altAdresser)
            {
                if (pa.TypeOfAdress != "Primary")
                {
                    PersonAddresses.Add(new SecondaryAdressDTO(pa.AlternativeAdress));
                }
            }

            foreach (Telephone pn in person.Telephones)
            {
                PhoneNumbers.Add(new PhoneNumberDTO(pn));
            }
        }

        //public Person ToPerson()
        //{
        //    List<AltAdresse> altAdresses = new List<AltAdresse>();
        //    foreach (var VARIABLE in PersonAddresses)
        //    {
                
        //    }

        //    return new Person() { PersonID = PersonId, GivenName = FirstName, MiddleName = MiddleName, FamilyName = LastName,
        //        altAdresser = PersonAddresses,
        //        Email = Email.d,
        //        PrimaryAddress_AddressId = PrimaryAddress.AddressId,
        //        PersonAddresses = PersonAddresses.Select(pa => pa.ToPersonAddress()).ToList(),
        //        PhoneNumbers = PhoneNumbers.Select(pn => pn.ToPhoneNumber()).ToList() };
        //}

        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public PrimaryAdressDTO PrimaryAddress { get; set; }

        public List<SecondaryAdressDTO> PersonAddresses { get; set; }

        public List<PhoneNumberDTO> PhoneNumbers { get; set; }
    }
}