using System.ComponentModel.DataAnnotations;

public class Account{
    [Key]
    public string Username { get; set; }
    public string Password { get; set; }
    public string Nickname { get; set; }

    public Manager Manager { get; set; }

    public User User { get; set; }

}