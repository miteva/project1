using Autofac;
using Registar.BusinessLayer.Contracts;
using Registar.Common;
using Registar.Common.Interfaces;
using Registar.DataLayer;
using Registar.DomainModel;
using Register.Repository;
using Register.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BusinessLayer.Handlers
{
    /// <summary>
    /// Class for Handling the Search Command for Bikes, inherits from generic class CommandHandlerBase
    /// </summary>
    internal class BikeSearchCommandHandler : CommandHandlerBase<BikeSearchCommand, BikeSearchResult>

    {

        /// <summary>
        /// override the base function ExecuteCommand, returns List of bikes that correspond to the search command
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        protected override BikeSearchResult ExecuteCommand(BikeSearchCommand command)
        {
             IContainer Container=RegisterComponents.RegisterAllComponents();
             using (var scope = Container.BeginLifetimeScope())
             {
                 //TODO if we want to use autofac for creating repositoryfatory we should use the commented line above the code
                 //var repo = scope.Resolve<IRepositoryFactory>();
                // var bikeRepo = repo.CreateRepository();
                // IBikeRepository repo = RepositoryManager.CreateRepository<IBikeRepository>();

                 //with this line using autofac we don't need our manually created factory, but directly we can create BikeRepository
                 //because IBikeRepository is mapped into BikeRepository
                 var repo = scope.Resolve<IBikeRepository>();
                 BikeSearchResult _result = new BikeSearchResult();

                 _result.Result = repo.SearchBike() as List<Bike>;
                 return _result;
             }

            

        }
    }
}

