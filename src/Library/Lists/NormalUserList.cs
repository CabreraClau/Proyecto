using System.Collections.ObjectModel;
using Library;

public class NormalUserList
{
    public IList<NormalUser> NormalUsers = new List<NormalUser>();
    public IList<NormalUser> NormalUser
    {
        get
        {
            return new ReadOnlyCollection<NormalUser>(this.NormalUsers);
        }
    }
    public void Adduser (NormalUser normaluser)
    {
      this.NormalUsers.Add(normaluser);
    }
    public bool IdExistence(long Id)
    {
      for (int i= 0; i < this.NormalUsers.Count; i++)
        {
            if (NormalUsers[i].Id == Id)
            {
                return true;
            }
        }
      return false;
    }
    public int GetIndexById(long Id)
    {
        for (int User = 0;  User < this.NormalUsers.Count; User ++)
        {
            if (NormalUsers[User].Id == Id)
            {
                return User;
            }
        }
        return -1;
    }
    public User GetUserById(long Id)
    {
        int index = GetIndexById(Id);
        return this.NormalUsers[index];
    }

    public void Clear()
    {
        this.NormalUsers.Clear();
    }

}