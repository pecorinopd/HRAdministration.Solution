using Microsoft.EntityFrameworkCore;

namespace HRAdministration.Server.Data
{
    public class HRAdministrationDBContext: DbContext
    {
        public HRAdministrationDBContext(DbContextOptions<HRAdministrationDBContext> options) : base(options) 
        { }
    }
}
