using Microsoft.EntityFrameworkCore;

namespace MYH_Reports.Data
{
    public class MyhContext : DbContext
    {
        public MyhContext(DbContextOptions<MyhContext> options) : base(options)
        {
        }
    }
}
