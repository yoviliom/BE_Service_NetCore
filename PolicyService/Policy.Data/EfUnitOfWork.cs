using Policy.Infrastructure.Interfaces;

namespace Policy.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly PolicyDbContext _context;

        public EFUnitOfWork(PolicyDbContext context)
        {
            _context = context;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }
    }
}