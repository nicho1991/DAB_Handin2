using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
public class Email
{
    public Email(string email)
    {
        UniqueEmail = email;
    }

    [Key]
    public string UniqueEmail { get; set; }
}