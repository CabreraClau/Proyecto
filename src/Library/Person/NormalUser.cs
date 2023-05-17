
using System;
namespace Library;
public class NormalUser : User
{
    public NormalUser(string Name, long Id, int phonenumber, string email, string direction) : base(Name, Id, phonenumber, email, direction)
    {
        this.Name = Name;
        this.Id = Id;
        this.PhoneNumber = phonenumber;
        this.Email = email;
        this.Direction = direction;
    }
}


