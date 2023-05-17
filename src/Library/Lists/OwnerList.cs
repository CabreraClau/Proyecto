using System.Collections.ObjectModel;
namespace Library;

public class OwnerList
{
    public IList<Owner> owners = new List<Owner>();
    public IList<Owner> Owner
    {
        get
        {
            return new ReadOnlyCollection<Owner>(this.owners);
        }
    }
    public void AddOwner(Owner owner)
    {
      this.owners.Add(owner);
    }
    public bool IdExistence(long Id)
    {
      for (int i= 0; i < this.owners.Count; i++)
        {
            if (owners[i].Id == Id)
            {
                return true;
            }
        }
      return false;
    }
    public int GetIndexById(long Id)
    {
        for (int Owner = 0;  Owner < this.owners.Count; Owner ++)
        {
            if (owners[Owner].Id == Id)
            {
                return Owner;
            }
        }
        return -1;
    }
    public Owner GetOwnerById(long Id)
    {
        int index = GetIndexById(Id);
        return this.owners[index];
    }

    public void Clear()
    {
        this.owners.Clear();
    }
}