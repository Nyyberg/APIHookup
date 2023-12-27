using apihookup.dto;
using ApiHookup.Models;

namespace apihookup.interfaces
{
    public interface ILogService
    {
        public void logNewEvent(string ErrorMessage, bool success, HookupBe hookup);

        public List<logDto> getAllLogs();

        public List<logDto> getLogsByHookupId(int id);

        public void deleteLogsByHookupId(int id);

        public void deleteLogById(int id);

    }
}
