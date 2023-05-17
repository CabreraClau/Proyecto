using System;
namespace Library;


public abstract class User
{
    public string Name {get; set; }
    public long Id {get; set;}
    public int PhoneNumber {get ; set;}
    public string Email {get; set;}
    public string Direction {get ; set;}
    
    public User(string Name, long Id, int phonenumber, string email, string direction)
    {
        this.Name = Name.Trim();
        this.Id = Id;
        this.PhoneNumber = phonenumber;
        this.Email = email;
        this.Direction = direction;
    }
}