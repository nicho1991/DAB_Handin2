using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class AltAdresse
{
    [Key]
    public int altAdrID { get; set; }
    public Adress AlternativeAdress { get; set; }
    public string TypeOfAdress { get; set; }
    
}

