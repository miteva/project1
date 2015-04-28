using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Common.Interfaces
{
    /// <summary>
    /// if we want to create factoryrepository with autofac we have to use the commented method instead of uncommented
    /// </summary>
    public interface IRepositoryFactory
    {
        TRepository CreateRepository<TRepository>() where TRepository : IRepository;
        //IRepository CreateRepository();
    }
}
