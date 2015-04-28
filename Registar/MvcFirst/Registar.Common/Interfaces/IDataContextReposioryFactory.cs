using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Common.Interfaces
{
    /// <summary>
    /// interface for manually creating the factoryrepository for the context
    /// </summary>
    public interface IDataContextReposioryFactory
    {
        TContext CreateContext<TContext>() where TContext : IDataContextRepository;
    }
}
