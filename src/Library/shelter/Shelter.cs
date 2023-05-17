namespace Library;
using System;


public class Shelter
{
    public string Owner {get; set;}
    public string Ubication {get; set;}
    public string NameShelter {get; set;}
    public int PhoneNumber {get; set;}
    public string Email {get; set;}
    public string WebSite{get; set;}
    public List<string>Humans =new List<string>();
    public List<string>Animals = new List<string>();

    public Shelter(string owner, string nameshelter, string ubication, string phonenumber, string Email, string website)
    {
        Humans = new List<string>();
        Animals = new List<string>();
    }
    public void AddHumans(string name)
    {
        Humans.Add(name);
    }
    public void AddAnimals(string name)
    {
        Animals.Add(name);
    }












}