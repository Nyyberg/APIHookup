using apihookup.dto;
using apihookup.interfaces;
using ApiHookup.Models;
using AutoMapper;

namespace apihookup.service
{
    public class HookupService : IHookupService
    {
        IHookupRepo _Repo;
        IMapper _Mapper;

        public HookupService(IHookupRepo hookupRepo, IMapper mapper) 
        {
            _Repo = hookupRepo;
            _Mapper = mapper;
        }

        public BodyDto AddBody(BodyDto dto)
        {
            //map dto to be
            Body body = _Mapper.Map<Body>(dto);
            Body addedBody =  _Repo.AddBody(body);
            return _Mapper.Map<BodyDto>(addedBody);
        }

        public HeaderDto AddHeader(HeaderDto dto)
        {
            //map dto to be
            Header header = _Mapper.Map<Header>(dto);
            //return mapped result
            return _Mapper.Map<HeaderDto>(_Repo.AddHeader(header));
        }

        public HookupDto AddHookup(HookupDto dto)
        {
            //map dto to be
            HookupBe hookup = _Mapper.Map<HookupBe>(dto);
            return _Mapper.Map<HookupDto>(_Repo.AddHookup(hookup));
        }

        public HookupDto GetHookupById(int id)
        {
            //map be to dto
            HookupBe be = _Repo.GetHookupById(id);
            HookupDto dto = _Mapper.Map<HookupDto>(be);
            return dto;
        }

        public List<HookupDto> GetHookups()
        {
            List<HookupBe> hookupBes =  _Repo.GetHookups();
            //map to dto
            List<HookupDto> hookupDtos = _Mapper.Map<List<HookupDto>>(hookupBes);
            return hookupDtos;

        }

        public void RemoveHookup(int id)
        {
            _Repo.RemoveHookup(id);
        }

        public BodyDto UpdateBody(BodyDto dto)
        {
           //map dto to be
            Body body = _Mapper.Map<Body>(dto);
            Body UpdatedBody = _Repo.UpdateBody(body);
            //map be to dto
            BodyDto UpdatedBodyDto = _Mapper.Map<BodyDto>(UpdatedBody);
            return UpdatedBodyDto;
        }

        public HeaderDto UpdateHeader(HeaderDto dto)
        {
            Header header = _Mapper.Map<Header>(dto);
            Header UpdatedHeader = _Repo.UpdateHeader(header);
            HeaderDto UpdatedHeaderDto = _Mapper.Map<HeaderDto>(UpdatedHeader);
            return UpdatedHeaderDto;
        }

        public HookupDto UpdateHookup(HookupDto dto)
        {
            HookupBe hookup = _Mapper.Map<HookupBe>(dto);
            return _Mapper.Map<HookupDto>(_Repo.UpdateHookup(hookup));

        }
    }
}
