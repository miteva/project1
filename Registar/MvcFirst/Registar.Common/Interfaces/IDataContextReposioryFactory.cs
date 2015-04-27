using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Common.Interfaces
{
    public interface IDataContextReposioryFactory
    {
        TContext CreateContext<TContext>() where TContext : IDataContextRepository;
    }
}
