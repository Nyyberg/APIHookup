using apihookup.interfaces;
using ApiHookup.Models;

namespace apihookup.repository
{
    public class LogRepo : ILogRepo
    {
        private readonly sqlContext _context;
        public LogRepo(sqlContext sqlContext) {
            _context = sqlContext;
        }

        public void deleteLogById(int id)
        {
            //try to find the log by id
            try
            {
                Log log = _context.Logs.Find(id) ?? throw new Exception("Log not found");
                _context.Logs.Remove(log);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void deleteLogsByHookupId(int id)
        {
            try
            {
                //find hookup by id
                HookupBe hookup = _context.HookupBes.Find(id) ?? throw new Exception("Hookup not found");
                //find all logs with hookup id
                List<Log> logs = _context.Logs.Where(x => x.HookupBeId == id).ToList();
                if (logs.Count == 0)
                {
                    throw new Exception("No logs found for this hookup");
                }
                //remove all logs
                _context.Logs.RemoveRange(logs);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Log> getAllLogs()
        {
            return _context.Logs.ToList();
            
        }

        public List<Log> getLogsByHookupId(int id)
        {
            //find the hookup by id
            HookupBe hookup = _context.HookupBes.Find(id) ?? throw new Exception("Hookup not found");

            List<Log> logs = _context.Logs.Where(x => x.HookupBeId == id).ToList();
            if (logs.Count == 0)
            {
                throw new Exception("No logs found for this hookup");
            }
            return logs;

        }

        public void logNewEvent(Log log)
        {
            try { 
                _context.Logs.Add(log); 
                _context.SaveChanges();
            }
            catch (Exception e) 
            { 
                throw new Exception(e.Message); 
            }
            
        }
    }
}
