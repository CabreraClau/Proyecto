using System;
namespace Library;


public class Person
{
    public string Name {get; }
    public int Id {get;}
    public int PhoneNumber {get ; set;}
    public string Email {get; set;}
    public string Direction {get ; set;}
    
    public Person(string name, int id, int phonenumber, string email, string direction)
    {
        this.Name = name;
        this.Id = id;
        this.PhoneNumber = phonenumber;
        this.Email = email;
        this.Direction = direction;

    }
    

    public void ContactShelter(Shelter shelter)
    {

    }
}