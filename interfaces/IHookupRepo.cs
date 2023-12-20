using apihookup.dto;
using apihookup.Models;

namespace apihookup.interfaces
{
    public interface IHookupRepo
    {
        //get all registered hookups
        List<HookupBe> GetHookups();

        //register a new hookup
        HookupBe RegisterHookup(HookupBe dto);
        //remove a hookup
        void RemoveHookup(int id);

        //update a hookup
        HookupBe UpdateHookup(HookupBe dto);
    }
}
