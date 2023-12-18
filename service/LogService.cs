using apihookup.interfaces;
using ApiHookup.Models;

namespace apihookup.service
{
    public class LogService : ILogService
    {
        private readonly ILogRepo _logRepo;
        public LogService(ILogRepo logRepo)
        {
            _logRepo = logRepo;
        }

        public void deleteLogById(int id)
        {
            _logRepo.deleteLogById(id);
        }

        public void deleteLogsByHookupId(int id)
        {
            _logRepo.deleteLogsByHookupId(id);
        }

        public List<Log> getAllLogs()
        {
            return _logRepo.getAllLogs();
        }

        public List<Log> getLogsByHookupId(int id)
        {
            return _logRepo.getLogsByHookupId(id);
        }

        public void logNewEvent(string ErrorMessage, bool success, HookupBe hookup)
        {
            Log log = new Log
            {
                ErrorMessage = ErrorMessage,
                IsSuccessful = success,
                HookupBeId = hookup.Id,
            };
        }
    }
}
