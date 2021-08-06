using System.Collections.Generic;

namespace AuthorizeRouteViewBlazorServer.Data
{
    public class SimulatedDataProviderService
    {
        public List<User> Users { get; set; } = new()
        {
            new()
            {
                Username = "User1",
                Password = "User1",
            },
            new()
            {
                Username = "User2",
                Password = "User2"
            },
            new()
            {
                Username = "User3",
                Password = "User3"
            }
        };

        public IEnumerable<string> GetUserRoles(User user)
        {
            var result = user.Username switch
            {
                "User1" => new List<string>() { "Admin", "User" },
                "User2" => new List<string>() { "User" },
                _ => new List<string>() { },
            };

            return result;
        }
    }
}