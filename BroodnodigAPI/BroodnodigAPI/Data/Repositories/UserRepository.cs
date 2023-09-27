//using DeSpaakEntity.Data;
//using SharedModels;

//namespace BroodnodigAPI.Data.Repositories
//{
//    public class UserRepository
//    {
//        private readonly BroodNodigContext context;

//        public UserRepository(BroodNodigContext broodNodigContext)
//        {
//            context = broodNodigContext;
//        }

//        public User GetUserById(Guid id)
//        {
//            var user = context.Users.FirstOrDefault(u => u.Id == id);
//            return user;
//        }
//        public ICollection<User> GetUserByName(string name)
//        {
//            var users = context.Users.Where(u => u.Name.Contains(name.ToLower())).ToList();
//            return users;

//        }
//        public ICollection<User> GetAllUsers()
//        {
//            var users = context.Users.ToList();
//            return users;
//        }
//        public void AddUser(User user)
//        {
//            user.Id = Guid.NewGuid();
//            user.Name = user.Name.ToLower();
//            context.Users.Add(user);
//            context.SaveChanges();
//        }
//        public void RemoveUser(User user)
//        {
//            context.Users.Remove(user);
//            context.SaveChanges();
//        }
//        public void UpdateUser(User existingUser, User user)
//        {
//            existingUser.Name = user.Name.ToLower();
//            existingUser.Email = user.Email;
//            context.SaveChanges();
//        }






//    }
//}
