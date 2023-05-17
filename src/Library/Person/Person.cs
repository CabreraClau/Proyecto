using System;
namespace Library;


public class Person
{
    public string Nombre {get; }
    public string Apellido {get ;}
    public int Identidad {get;}
    public int Telefono {get ; set;}
    public string Correo {get; set;}
    public string Direccion {get ; set;}
    
    public Person(string nombre, string apellido, int identidad, int telefono, string correo, string direccion)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Identidad = identidad;
        this.Telefono = telefono;
        this.Correo = correo;
        this.Direccion = direccion;

    }
    

    public void ContactShelter(Shelter shelter)
    {

    }
}