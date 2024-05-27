using Task3_AuthenticationAPI.Models;

namespace Task3_AuthenticationAPI.Model
{
    public static class UserStore
    {
        public static List<User> Users =
        [
            new() { Username = "user1", Password = "password1", Roles = ["player"], Regions = ["b_game"] },
            new() { Username = "admin", Password = "adminpassword", Roles = ["admin"], Regions = ["b_game", "vip_chararacter_personalize"] }
        ];
    }



}
