using System.Collections.ObjectModel;
using Library;
public class SheltersList
{
    private IList<Shelter> Shelters = new List<Shelter>();
    public IList<Shelter> Shelter
    {
        get
        {
            return new ReadOnlyCollection<Shelter>(this.Shelters);
        }
    }
    public void Add(Shelter shelter)
    {
        this.Shelters.Add(shelter);
    }
    public void Remove()
    {

    }
    public bool ShelterExistence(string nameshelter)
    {
        return false;
    }
    public void Clear()
    {
        this.Shelters.Clear();
    }
}
