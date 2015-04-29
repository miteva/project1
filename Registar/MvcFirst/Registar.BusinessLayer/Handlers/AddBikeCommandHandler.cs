using Autofac;
using Registar.BusinessLayer.Contracts;
using Registar.Common;
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
    public class AddBikeCommandHandler : CommandHandlerBase<AddBikeCommand, AddBikeResult>
    {
        protected override AddBikeResult ExecuteCommand(AddBikeCommand command)
        {
            IContainer Container = RegisterComponents.RegisterAllComponents();
            using (var scope = Container.BeginLifetimeScope())
            {
                IBikeRepository repo = RepositoryManager.CreateRepository<IBikeRepository>();
                AddBikeResult _result = new AddBikeResult();
                Bike b = new Bike();
                b.BikeOwnerId = 1;
                b.City = "Skopje";
                b.Colour = "Red";
                b.Prdoucer = "BP";
                b.Model = "CityBe";
                b.RegNumber = "BP123";
                if (b.Model != "CityBike")
                {
                    _result.IsSuccesed = false;
                    _result.Errors.Add("The model of the bike is not allowed for the producer");

                }
                else
                {
                    _result.IsSuccesed = true;
                    _result.Bike = repo.AddBike(b);
                }
                    
                
                return _result;
            }
        }
    }
}
