using Registar.Common.Interfaces;
using Registar.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Repository
{
    /// <summary>
    /// if we manualy create the factory(not with autofac) we will need this class
    /// </summary>
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
