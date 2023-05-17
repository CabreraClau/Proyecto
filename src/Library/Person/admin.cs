namespace Library;
public class Admin : User
{
     public Admin(string Name, long Id, int phonenumber, string email, string direction) : base(Name, Id, phonenumber, email, direction)
    {
        this.Name = Name;
        this.Id = Id;
        this.PhoneNumber = phonenumber;
        this.Email = email;
        this.Direction = direction;
    }
        
}