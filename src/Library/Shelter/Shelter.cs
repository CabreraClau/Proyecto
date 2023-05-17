namespace Library;
using System;


public class Shelter
{
    public Owner Owner {get; set;}
    public Rating Rating {get;set;}
    public string Ubication {get; set;}
    public string NameShelter {get; set;}
    public int PhoneNumber {get; set;}
    public string Email {get; set;}
    public string WebSite{get; set;}
    public string Description{get;set;}

    public Shelter(Owner owner, string nameshelter, string ubication, int phonenumber, string email, string website, string description)
    {
        this.Owner = owner;
        this.NameShelter = nameshelter;
        this.Ubication = ubication;
        this.PhoneNumber = phonenumber;
        this.Email = email;
        this.WebSite = website;
        this.Description = description;
        this.Rating = new Rating();
    }
}