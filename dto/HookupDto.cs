using apihookup.be;

namespace apihookup.dto
{
    /// <summary>
    /// hookup dto contains all relevant data to call an api endpoint and is used to register and dispach api calls
    /// </summary>
    public class HookupDto
    {
        public int? id { get; set; }
        /// <summary>
        /// endpoint to call
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// get, post, put, delete
        /// </summary>
        public string methodType { get; set; }

        public List<DateTime>? time { get; set; }
    }
}
