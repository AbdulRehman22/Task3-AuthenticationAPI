using Task3_AuthenticationAPI.DTOs;
using Task3_AuthenticationAPI.Interfaces;
using Task3_AuthenticationAPI.Models;

namespace Task3_AuthenticationAPI.Services
{
    public class UserService : IUser
    {
        private readonly List<User> _users =
       [
           new() { Username = "user1", Password = "password1", Role = "player", Regions = ["b_game"] },
           new() { Username = "admin", Password = "adminpassword", Role = "admin", Regions = ["b_game", "vip_chararacter_personalize"] }
       ];
        public User? Authenticate(LoginResquest resquest)
        {
            try
            {
                var user = _users.FirstOrDefault(u => u.Username == resquest.Username && u.Password == resquest.Password);
                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
