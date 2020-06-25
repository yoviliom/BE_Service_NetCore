using System;

namespace Policy.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();
    }
}