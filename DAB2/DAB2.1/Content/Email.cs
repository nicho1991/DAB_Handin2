using System.ComponentModel.DataAnnotations;

public class Email
{
    public Email(string email)
    {
        UniqueEmail = email;
    }
    [Key]
    public int emailID { get; set; }
    public string UniqueEmail { get; set; }
}