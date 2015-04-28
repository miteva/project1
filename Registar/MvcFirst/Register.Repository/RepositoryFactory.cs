using Registar.Common.Interfaces;
using Register.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Repository
{
    /// <summary>
    /// if we want to create factoryrepository with autofac we have to use the commented lines.
    /// </summary>
    public class DefaultRepositoryFactory : IRepositoryFactory
    {
       public  IRepository Repository { set; get; }

       public TRepository CreateRepository<TRepository>() where TRepository : IRepository
       {
           if (typeof(TRepository) == typeof(IBikeRepository))
           {
               return (TRepository)(object)new BikeRepository();
           }
           return default(TRepository);
       }
       //public DefaultRepositoryFactory(IRepository repository) 
       //{
       //    this.Repository = repository;
       //}

       //public  IRepository CreateRepository() 
       //{
       //    return this.Repository;
       //}
    }
}
