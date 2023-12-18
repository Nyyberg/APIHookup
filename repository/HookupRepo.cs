using apihookup.dto;
using apihookup.interfaces;
using ApiHookup.Models;
using Microsoft.EntityFrameworkCore;

namespace apihookup.repository
{
    public class HookupRepo : IHookupRepo
    {
        private readonly sqlContext _context;
        public HookupRepo(sqlContext dbContext)
        {
            _context = dbContext;
        }

        public Body AddBody(Body body)
        {
            _context.Add(body);
            _context.SaveChanges();
            return body;
        }

        public Header AddHeader(Header header)
        {
            _context.Add(header);
            _context.SaveChanges();
            return header;
        }

        public HookupBe AddHookup(HookupBe hookup)
        {
            _context.Add(hookup);
            _context.SaveChanges();
            return hookup;
        }

        public HookupBe GetHookupById(int id)
        {
            return _context.Set<HookupBe>().Find(id) ?? throw new Exception("could not find the Hookup");
        }

        public List<HookupBe> GetHookups()
        {
            return _context.Set<HookupBe>().ToList();
        }

        public void RemoveHookup(int id)
        {
            _context.Set<HookupBe>().Remove(GetHookupById(id));
            _context.SaveChanges();
        }

        public Body UpdateBody(Body body)
        {
            _context.Set<Body>().Update(body);
            _context.SaveChanges();
            return body;
        }

        public Header UpdateHeader(Header header)
        {
            _context.Set<Header>().Update(header);
            _context.SaveChanges();
            return header;
        }

        public HookupBe UpdateHookup(HookupBe hookup)
        {
            _context.Set<HookupBe>().Update(hookup);
            _context.SaveChanges();
            return hookup;
        }
    }
}
