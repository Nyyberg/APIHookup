using apihookup.dto;

namespace apihookup.interfaces
{
    public interface IHookupService
    {
        //get all registered hookups
        List<HookupDto> GetHookups();

        //add a body
        BodyDto AddBody(BodyDto dto);

        //add a hookup
        HookupDto AddHookup(HookupDto dto);

        //add a header
        HeaderDto AddHeader(HeaderDto dto);

        //update a body
        BodyDto UpdateBody(BodyDto dto);

        //update a header
        HeaderDto UpdateHeader(HeaderDto dto);

        //get a hookup by id
        HookupDto GetHookupById(int id);

        //remove a hookup
        void RemoveHookup(int id);

        //update a hookup
        HookupDto UpdateHookup(HookupDto dto);
        object? AddListOfCalender(List<IntervalDto> dtos);
        object? AddSingleCalender(IntervalDto dto);
        void RemoveCalender(int id);
        object? GetAllCalenders(int id);
    }
}
