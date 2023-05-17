using System.Collections.ObjectModel;
namespace Library;

public class UserList
{
    public IList<User> users = new List<User>();
    public IList<User> User
    {
        get
        {
            return new ReadOnlyCollection<User>(this.users);
        }
    }
    public void Adduser (User user)
    {
      this.users.Add(user);
    }
    public bool IdExistence(long Id)
    {
      for (int i= 0; i < this.users.Count; i++)
        {
            if (users[i].Id == Id)
            {
                return true;
            }
        }
      return false;
    }
    public int GetIndexById(long Id)
    {
        for (int User = 0;  User < this.users.Count; User ++)
        {
            if (users[User].Id == Id)
            {
                return User;
            }
        }
        return -1;
    }
    public User GetUserById(long Id)
    {
        int index = GetIndexById(Id);
        return this.users[index];
    }

    public void Clear()
    {
        this.users.Clear();
    }
}