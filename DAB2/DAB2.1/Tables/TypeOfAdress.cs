using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TypeOfAdress
{
    // Set the column order so it appears nice in the database
    [Key, Column(Order = 0)]
    public int PersonID { get; set; }

    [Key, Column(Order = 1)]
    public int AdressId { get; set; }

    // Add the navigation properties
    public virtual Person Person { get; set; }

    public virtual Adress Adress { get; set; }

    // Add any additional fields you need
    public string AdressType { get; set; }

}
