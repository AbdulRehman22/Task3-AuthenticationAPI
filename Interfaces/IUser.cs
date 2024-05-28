using Task3_AuthenticationAPI.DTOs;
using Task3_AuthenticationAPI.Models;

namespace Task3_AuthenticationAPI.Interfaces
{
    public interface IUser
    {
        User? Authenticate(LoginResquest resquest);
    }
}
