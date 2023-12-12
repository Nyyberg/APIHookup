using apihookup.interfaces;
using apihookup.Models;

namespace apihookup.repository
{
    public class LogRepo : ILogRepo
    {
        public void deleteLogById(int id)
        {
            throw new NotImplementedException();
        }

        public void deleteLogsByHookupId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Log> getAllLogs()
        {
            throw new NotImplementedException();
        }

        public List<Log> getLogsByHookupId(int id)
        {
            throw new NotImplementedException();
        }

        public void logNewEvent(string ErrorMessage, bool success, HookupBe hookup)
        {
            throw new NotImplementedException();
        }
    }
}
