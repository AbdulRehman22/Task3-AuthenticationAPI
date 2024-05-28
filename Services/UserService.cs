using Task3_AuthenticationAPI.DTOs;
using Task3_AuthenticationAPI.Interfaces;
using Task3_AuthenticationAPI.Models;

namespace Task3_AuthenticationAPI.Services
{
    public class UserService : IUser
    {
        private readonly List<User> _users =
       [
           new() { Username = "user1", Password = "password1", Roles = ["player"], Regions = ["b_game"] },
           new() { Username = "admin", Password = "adminpassword", Roles = ["admin"], Regions = ["b_game", "vip_chararacter_personalize"] }
       ];
        public User? Authenticate(LoginResquest resquest)
        {
            var user = _users.SingleOrDefault(u => u.Username == resquest.Username && u.Password == resquest.Password);
            return user;
        }
    }
}
