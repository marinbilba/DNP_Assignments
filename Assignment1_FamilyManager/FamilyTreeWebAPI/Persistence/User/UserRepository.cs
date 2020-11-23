namespace FamilyTreeWebAPI.Persistence.User

{
    public class UserRepository :IUserRepository
    {
        private FamilyManagerContext familyManagerContext;
        public UserRepository(FamilyManagerContext familyManagerContext)
        {
            this.familyManagerContext = familyManagerContext;
        }

        public SharedClasses.Models.User ValidateUser(SharedClasses.Models.User user)
        {
            throw new System.NotImplementedException();
        }
    }
}