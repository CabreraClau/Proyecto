namespace Library;
public class NormalUser : Person
{
    public NormalUser(string nombre, string apellido, int ci, int telefono, string correo, string direccion)
 : base(nombre, apellido, ci, telefono, correo, direccion)
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


