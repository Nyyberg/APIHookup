using apihookup.dto;

namespace apihookup.interfaces
{
    public interface IHookupRepo
    {
        //get all registered hookups
        List<HookupDto> GetHookups();

        //register a new hookup
        HookupDto RegisterHookup(HookupDto dto);
        //remove a hookup
        void RemoveHookup(int id);

        //update a hookup
        HookupDto UpdateHookup(HookupDto dto);
    }
}
