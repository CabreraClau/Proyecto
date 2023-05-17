using System.Collections.ObjectModel;
public class CategoriesList
{
    private IList<string> categories = new List<string>();
    public IList<string> Categories
    {
        get
        {
            return new ReadOnlyCollection<string>(this.categories);
        }
    }
    public void Add(string category)
    {
        this.categories.Add(category);
    }
    public void Remove(string category)
    {
    }
    public void Clear()
    {
        this.categories.Clear();
    }
}