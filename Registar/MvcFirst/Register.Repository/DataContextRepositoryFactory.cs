using Registar.Common.Interfaces;
using Registar.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Repository
{
    public class DataContextRepositoryFactory : IDataContextReposioryFactory
    {
        public TContext CreateContext<TContext>() where TContext : IDataContextRepository
        {
            if (typeof(TContext) == typeof(IRegistarContext))
            {
                return (TContext)(object)new RegistarDbContext();
            }
            return default(TContext);
        }
    }
}
