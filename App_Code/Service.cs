using System.Web.Services;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    [WebMethod]
    public User SelectUser(int userId)
    {
        using (var db = new MyDbContext())
        {
            return db.Users.Find(userId);
        }
    }

    [WebMethod]
    public string InsertUser(User user)
    {
        using (var db = new MyDbContext())
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        return "The user " + user.Name + " was inserted successfully.";
    }

    [WebMethod]
    public string DeleteUser(int user)
    {
        using (var db = new MyDbContext())
        {
            var x = db.Users.Find(user);
            db.Users.Remove(x);
            db.SaveChanges();
        }

        return "The user was removed successfully";
    }

    [WebMethod]
    public string UpdateUser(User user)
    {
        using (var db = new MyDbContext())
        {
            var userToUpdate = db.Users.Find(user.Id);
            userToUpdate.Name = user.Name;
            userToUpdate.LastName = user.LastName;
            userToUpdate.Email = user.Email;
            db.SaveChanges();
        }
        return "The user " + user.Name + " was updated successfully.";
    }
}
