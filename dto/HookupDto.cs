namespace apihookup.dto
{
    /// <summary>
    /// hookup dto contains all relevant data to call an api endpoint and is used to register and dispach api calls
    /// </summary>
    public class HookupDto
    {
        int? id { get; set; }
        //url of the api endpoint
        string url { get; set; }
        //get/post/put/delete
        string method { get; set; }


    }
}
