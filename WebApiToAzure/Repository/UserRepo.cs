using WebApiToAzure.Models;

namespace WebApiToAzure.Repository

{
    public static class UserRepo
    {
        private static List<User> _users = new List<User>();
        
        public static IEnumerable<User> _Users { 
            
            get { return _users; } 
        
        }

        public static void AddUser(User user)
        {
            _users.Add(user);
        }


    }
}
