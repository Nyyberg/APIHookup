
using ApiHookup.Models;

namespace apihookup.interfaces
{
    public interface ILogRepo
    {
        public void logNewEvent(Log log);

        public List<Log> getAllLogs();

        public List<Log> getLogsByHookupId(int id);

        public void deleteLogsByHookupId(int id);

        public void deleteLogById(int id);
    }
}
