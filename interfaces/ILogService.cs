using apihookup.dto;
using ApiHookup.Models;

namespace apihookup.interfaces
{
    public interface ILogService
    {
        public void logNewEvent(logDto log);

        public List<logDto> getAllLogs();

        public List<logDto> getLogsByHookupId(int id);

        public void deleteLogsByHookupId(int id);

        public void deleteLogById(int id);

    }
}
