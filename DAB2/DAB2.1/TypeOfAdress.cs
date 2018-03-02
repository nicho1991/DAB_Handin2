using System.Collections;
using System.Collections.Generic;

public static class TypeOfAdress
{
    static public List<item> items = new List<item>();
}

public class item
{
    public string type { get; set; }

    public Person personer { get; set; }

    public Adress adresse { get; set; }
}