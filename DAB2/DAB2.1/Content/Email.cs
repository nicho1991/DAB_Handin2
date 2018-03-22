using System.ComponentModel.DataAnnotations;

public class Email
{
    public Email(string email)
    {
        UniqueEmail = email;
    }

    [Key] public string UniqueEmail { get; set; }
}