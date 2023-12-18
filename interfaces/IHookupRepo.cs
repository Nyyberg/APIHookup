using apihookup.dto;
using ApiHookup.Models;

namespace apihookup.interfaces
{
    public interface IHookupRepo
    {
        //get all registered hookups
        List<HookupBe> GetHookups();

        //add a body
        Body AddBody(Body body);

        //add a hookup
        HookupBe AddHookup(HookupBe hookup);

        //add a header
        Header AddHeader(Header header);

        //update a body
        Body UpdateBody(Body body);

        //update a header
        Header UpdateHeader(Header header);

        //get a hookup by id
        HookupBe GetHookupById(int id);

        //remove a hookup
        void RemoveHookup(int id);

        //update a hookup
        HookupBe UpdateHookup(HookupBe hookup);
    }
}
