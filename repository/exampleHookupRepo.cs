using apihookup.dto;
using apihookup.interfaces;
using apihookup.Models;

namespace apihookup.repository
{
    public class exampleHookupRepo : IHookupRepo
    {
        public List<HookupBe> GetHookups()
        {
            //create a Completed hookupBe with body and header
            throw new NotImplementedException();
        }

        public HookupBe RegisterHookup(HookupBe be)
        {
            throw new NotImplementedException();
        }

        public void RemoveHookup(int id)
        {
            throw new NotImplementedException();
        }

        public HookupBe UpdateHookup(HookupBe be)
        {
            throw new NotImplementedException();
        }
    }
}
