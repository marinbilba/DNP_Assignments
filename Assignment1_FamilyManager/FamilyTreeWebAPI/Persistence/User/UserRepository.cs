using System;
using Microsoft.EntityFrameworkCore;

namespace FamilyTreeWebAPI.Persistence.User

{
    public class UserRepository :IUserRepository
    {
        private FamilyManagerContext familyManagerContext;
        public UserRepository(FamilyManagerContext familyManagerContext)
        {
            this.familyManagerContext = familyManagerContext;
           
        }
        public void AddUser(SharedClasses.Models.User user)
        {
            Console.WriteLine("yes yes");
            familyManagerContext.User.Add(user);
            //?????????
            familyManagerContext.Entry(user).State = EntityState.Added;
            familyManagerContext.SaveChanges();
        }
        public SharedClasses.Models.User GetUser(SharedClasses.Models.User user)
        {
            return familyManagerContext.User.Find(user.UserName);
        }
    }
}