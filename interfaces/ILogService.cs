using ApiHookup.Models;

namespace apihookup.interfaces
{
    public interface ILogService
    {
        public void logNewEvent(string ErrorMessage, bool success, HookupBe hookup);

        public List<Log> getAllLogs();

        public List<Log> getLogsByHookupId(int id);

        public void deleteLogsByHookupId(int id);

        public void deleteLogById(int id);

    }
}
