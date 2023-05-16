namespace Library;
public class NormalUser : Person
{
    public NormalUser(string nombre, string apellido, int ci, int telefono, string correo, string direccion): base(nombre, apellido, ci, telefono, correo, direccion)
    {

    }
    public void CalificarRefugio(Refugio refugio, int calificacion)
    {

    }
    public void AdoptarAnimal(Refugio refugio, Animal animal)
    {

    }
    public void ColaborarRefugio(Refugio refugio, float monto)
    {

    }
    public List<Refugio> BuscarRefugio (string criterioBusqueda)
    {


        return new list<Refugio>();
    }
}


