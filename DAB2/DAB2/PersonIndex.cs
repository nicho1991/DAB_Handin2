using System;
using System.Collections.Generic;

public class PersonIndex
{
    public List<Person> persons;

    public void AddPerson(Person person)
    {
        persons.Add(person);
    }

    public List<Person> GetPersons()
    {
        return persons;
    }

}