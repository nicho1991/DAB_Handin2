using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

            PrimaryAddress = new AddressDTO(person.);

            PersonAddresses = new List<PersonAddressDTO>();

            PhoneNumbers = new List<PhoneNumberDTO>();

            foreach (PersonAddress pa in person.PersonAddresses)
            {
                PersonAddresses.Add(new PersonAddressDTO(pa));
            }

            foreach (PhoneNumber pn in person.PhoneNumbers)
            {
                PhoneNumbers.Add(new PhoneNumberDTO(pn));
            }
        }

        public Person ToPerson()
        {
            return new Person() { PersonID = PersonId, GivenName = FirstName, MiddleName = MiddleName, FamilyName = LastName,
                altAdresser = d,
                Email = Email.d,
                PrimaryAddress_AddressId = PrimaryAddress.AddressId,
                PersonAddresses = PersonAddresses.Select(pa => pa.ToPersonAddress()).ToList(),
                PhoneNumbers = PhoneNumbers.Select(pn => pn.ToPhoneNumber()).ToList() };
        }

        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public AddressDTO PrimaryAddress { get; set; }

        public List<PersonAddressDTO> PersonAddresses { get; set; }

        public List<PhoneNumberDTO> PhoneNumbers { get; set; }
    }
}