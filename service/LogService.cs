using apihookup.dto;
using apihookup.interfaces;
using ApiHookup.Models;
using AutoMapper;

namespace apihookup.service
{
    public class LogService : ILogService
    {
        private readonly ILogRepo _logRepo;
        private readonly IMapper _mapper;
        public LogService(ILogRepo logRepo, IMapper mapper)
        {

            _logRepo = logRepo;
            _mapper = mapper;
        }

        public void deleteLogById(int id)
        {
            _logRepo.deleteLogById(id);
        }

        public void deleteLogsByHookupId(int id)
        {
            _logRepo.deleteLogsByHookupId(id);
        }

        public List<logDto> getAllLogs()
        {
            return _mapper.Map<List<logDto>>(_logRepo.getAllLogs());
        }

        public List<logDto> getLogsByHookupId(int id)
        {
            return _mapper.Map<List<logDto>>(_logRepo.getLogsByHookupId(id));
        }

        public void logNewEvent(logDto log)
        {
           _logRepo.logNewEvent(_mapper.Map<Log>(log));
        }
    }
}
