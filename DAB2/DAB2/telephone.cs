public class Telephone
{
    public Telephone(string telephoneNumber, string phoneCompany, string usage)
    {
        _phoneCompany = phoneCompany;
        _telephoneNumber = telephoneNumber;
        _usageOfTlf = usage;
    }


    public string _phoneCompany { get; set; }
    public string _telephoneNumber { get; set; }
    public string _usageOfTlf { get; set; }
}