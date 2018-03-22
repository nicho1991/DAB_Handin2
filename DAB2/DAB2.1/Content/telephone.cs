using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

public class Telephone
{
    public Telephone()
    {

    }
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

    [ForeignKey("Person")]
    public int PersonRefId { get; set; }
    public Person Person { get; set; }

}