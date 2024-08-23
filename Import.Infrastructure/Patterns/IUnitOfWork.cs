using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.Infrastructure.Patterns
{
    public interface IUnitOfWork : IDisposable
    {
        Task SaveChanges();
    }
}
