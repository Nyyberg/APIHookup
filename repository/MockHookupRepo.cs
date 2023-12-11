using apihookup.be;
using apihookup.dto;
using apihookup.interfaces;

namespace apihookup.repository
{
    public class MockHookupRepo : IHookupRepo
    {
        public List<HookupDto> GetHookups()
        {
            //create a list of hookups
            List<HookupDto> hookups = new List<HookupDto>();
            //create a hookup
            HookupDto hookup1 = new HookupDto
            {
                id = 1,
                url = "https://localhost:5001/api/endpoint",
                methodType = "get",
                body = new List<Dictionary<string, string>> { { new Dictionary<string, string> { { "rng", "SELECT TOP 1 * FROM D&D ORDER BY ID DESC WHERE D&D.RNG" } } } },
                header = new List<Dictionary<string, string>> { { new Dictionary<string, string> { { "AUTHENTICATE", "yourMAMA" } } } },
                CustomInterval = new CustomCalender
                {
                    isEveryDay = false,
                    isEveryMonth = true,
                    isEveryWeek = false,
                    timeOfDay = new DateTime(2023, 12, 24, 20, 0, 0),
                    customInterval = null
                }
            };
            //add the hookup to the list
            hookups.Add(hookup1);
            //return the list
            return hookups;
        }

        public HookupDto RegisterHookup(HookupDto dto)
        {
            dto.id = 40000;
            return dto;
        }

        public void RemoveHookup(int id)
        {
            throw new NotImplementedException();
        }

        public HookupDto UpdateHookup(HookupDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
