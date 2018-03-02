using System.Collections.Generic;

public class Person
{
    private Email email;
    private string familyName;
    private Adress fRA;
    private string givenName;
    private string middleName;

    private PersonIndex personIndex;
    private Telephone[] telephones;
    private TypeOfAdress[] typeOfAdress2;

    public List<Adress> Adresses { get; set; }
}