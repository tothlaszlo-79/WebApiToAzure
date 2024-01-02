using WebApiToAzure.Repository;


namespace WebApiToAzure.Data
{
    public static class AddUsers
    {
        public static void AddTestUsers()
        {
            UserRepo.AddUser(new Models.User { Name = "admin", Password = "admin", Role = "Administrator" });
            UserRepo.AddUser(new Models.User { Name = "user", Password = "user", Role = "User" });
        }
    }
}
