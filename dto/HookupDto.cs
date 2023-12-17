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
        /// <summary>
        /// body of the request 
        /// example body:
        /// body.Add(
        /// </summary>
        public List<bodyDto> bodies { get; set; }
        /// <summary>
        /// header of the request
        /// example header:
        /// header.Add(new Dictionary<string, string> { { "keyName", "value" } });
        /// </summary>
        public List<Dictionary<string, string>>? header { get; set; } 

        public CustomCalender? CustomInterval { get; set; }
    }
}
