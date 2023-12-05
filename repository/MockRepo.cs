using apihookup.dto;
using apihookup.interfaces;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using System.Text;
using apihookup.be;

namespace apihookup.repository
{
    public class MockRepo : IAuthRepo
    {
        User testUser = new User()
        {
            username = "test",
            password = "test"
        };
        User admin = new User()
        {
            username = "admin",
            password = "admin"
        };
        List<User> users = new List<User>();
        public MockRepo()
        {
            users.Add(testUser);
            users.Add(admin);
        }
        public User? getUser(loginDto dto)
        {
            //compare the username of the dto to the username of the users in the list and return the user if found
            return users.Find(user => user.username == dto.username);
            }
        }
}
