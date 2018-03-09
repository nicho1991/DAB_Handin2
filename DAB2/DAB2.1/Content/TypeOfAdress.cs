using System.Collections.Generic;

public static class TypeOfAdress
{
    public static List<Item> Items = new List<Item>();
}

public class Item
{
    public string Type { get; set; }

    public Person Personer { get; set; }

    public Adress Adresse { get; set; }
}