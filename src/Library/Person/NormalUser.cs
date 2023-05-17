namespace Library;
public class NormalUser : Person
{
    public NormalUser(string name, int id, int phonenumber, string email, string direction)
 : base(name, id, phonenumber, email, direction)
    {

    }
    public void CalificarShelter(Shelter Shelter, int calificacion)
    {

    }
    public void AdoptarAnimal(Shelter Shelter, String animal)
    {

    }
   
    public List<Shelter> SearchShelter (string criterioBusqueda)
    {


        return new List<Shelter>();
    }
}


