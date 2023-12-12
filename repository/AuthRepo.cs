using apihookup.be;
using apihookup.dto;
using apihookup.interfaces;

namespace apihookup.repository
{
    public class AuthRepo : IAuthRepo
    {
        /// <summary>
        /// gets a user from the database by the username
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>
        /// a user object with username and password if found
        /// </returns>
        /// <exception cref="NotImplementedException"></exception>
        public User getUser(IoginDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
