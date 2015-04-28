using Registar.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Common
{
    /// <summary>
    /// class for manually creating context from factory
    /// </summary>
   public class DataContextManager
    {
        public static IDataContextReposioryFactory theFactory;

        public static TContext CreateContext<TContext>() where TContext : IDataContextRepository
        {
            TContext result = theFactory.CreateContext<TContext>();
            return result;
        }

        public static void RegisterFactory(IDataContextReposioryFactory factory)
        {
            theFactory = factory;
        }
    }
}
