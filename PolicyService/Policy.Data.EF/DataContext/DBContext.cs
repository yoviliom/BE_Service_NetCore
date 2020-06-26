using Microsoft.EntityFrameworkCore;

namespace Policy.Data.ConnectContext
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DbContext> options) : base(options)
        {

        }
    }
}
