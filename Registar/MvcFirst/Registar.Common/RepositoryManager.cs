using Registar.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Common
{
    public class RepositoryManager
    {
        public static IRepositoryFactory theFactory;
        public static TRepository CreateRepository<TRepository>() where TRepository : IRepository
        {


            return theFactory.CreateRepository<TRepository>();
        }

        public static void RegisterFactory(IRepositoryFactory factory)
        {
            theFactory = factory;
        }
    }
}
