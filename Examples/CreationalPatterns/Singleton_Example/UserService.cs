using System;

namespace Singleton_Example
{
    public class UserService : IUserService
    {
        private static UserService _userService;

        private UserService()
        { }

        public static UserService GetService()
        {
            if (_userService == null)
            {
                _userService = new UserService();
            }

            return _userService;
        }

        public void DeleteUser(int id)
        {
            Console.WriteLine("User with id=" + id + " was deleted!");
        }
    }
}
