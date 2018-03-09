using System.ComponentModel.DataAnnotations;

public class Telephone
{
    public Telephone(string telephoneNumber, string phoneCompany, string usage)
    {
        PhoneCompany = phoneCompany;
        TelephoneNumber = telephoneNumber;
        UsageOfTlf = usage;
    }
    [Key]
    public int telephoneID { get; set; }
    public string PhoneCompany { get; set; }
    public string TelephoneNumber { get; set; }
    public string UsageOfTlf { get; set; }
}