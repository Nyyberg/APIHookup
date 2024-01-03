using apihookup.dto;
using apihookup.interfaces;
using Newtonsoft.Json;
using System.Text;

namespace apihookup.builder
{
    public class GetApiCaller : IapiCaller
    {
        string _url;
        Dictionary<string, string> _body;
        Dictionary<string, string> _header;
        int _hookupId;
        ILogService _logService;

        public GetApiCaller(string url, Dictionary<string, string> body, Dictionary<string, string> header, int hookupId, ILogService logService)
        {
            _url = url;
            _body = body;
            _header = header;
            _logService = logService;
            _hookupId = hookupId;
        }

        public async void callApi()
        {
            logDto log = new logDto();
            try
            {
                using (var httpClient = new HttpClient())
                {
                    //add the query string to the url
                    if (_body != null && _body.Count > 0)
                    {
                        // Build the query string with multiple parameters using foreach loop
                        var queryString = "";
                        foreach (var kvp in _body)
                        {
                            queryString += $"{Uri.EscapeDataString(kvp.Key)}={Uri.EscapeDataString(kvp.Value)}&";
                        }
                        _url += "?" + queryString.TrimEnd('&');
                    }

                    //create a get call to an api with this.url and _header
                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri(_url),
                        Content = new StringContent(JsonConvert.SerializeObject(_body), Encoding.UTF8, "application/json")
                    };

                    //add the headers to the request
                    if (_header != null)
                    {
                        foreach (var header in _header)
                        {
                            httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
                        }
                    }

                    //send the request and get the response
                    var response = await httpClient.SendAsync(request);
                    //read the response
                    var responseString = await response.Content.ReadAsStringAsync();
                    //log the response
                    log = new logDto()
                    {
                        HookupBeId = _hookupId,
                        IsSuccessful = true,
                        ErrorMessage = responseString,
                        Timestamp = DateTime.Now
                    };
                }
            }
            catch (Exception e)
            {
                //log the error
                log = new logDto()
                {
                    HookupBeId = _hookupId,
                    IsSuccessful = false,
                    ErrorMessage = e.Message,
                    Timestamp = DateTime.Now
                };
            }
            finally
            {
                //log the event
                _logService.logNewEvent(log);
            }
        }
    }
}
