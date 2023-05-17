using Library;
public class Register
{
    public static User SaveData(bool opc, long ID, string Name, int PhoneNumber, string Email, string Location)
    {
        if (!opc)
        {
            NormalUser normalUser = new NormalUser(Name, ID, PhoneNumber, Email, Location);
            //NormalUsers.Add(normalUser);
            return normalUser;
        }
        else
        {
            Owner owner = new Owner(Name, ID, PhoneNumber , Email, Location);
            //owners.Add(normalUser);
            return owner;
        }
    }

}