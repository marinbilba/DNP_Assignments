
using SharedClasses.Models;



public interface IUserRepository
    {
      
       User GetUser(User user);
       void AddUser(User user);
    }
