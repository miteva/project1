using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registar.BusinessLayer;
using Registar.BusinessLayer.Handlers;
using Registar.BusinessLayer.Contracts;
using Register.Repository.Interfaces;
using Registar.DomainModel;
using System.Collections.Generic;
using Registar.Common.Interfaces;
using Registar.Common;
using Registar.DataLayer;

namespace Registar.BusinessLayer.Tests
{
    [TestClass]
    public class BikeSearchCommandHandlerUnitTests
    {
        [TestMethod]
        public void ExecuteBikeSearchCommand_SmokeTest_NoException_Test()
        {
            //setup
            BikeSearchCommandHandler handler = new BikeSearchCommandHandler();
            BikeSearchCommand command = new BikeSearchCommand();
            RepositoryManager.RegisterFactory(new BikeRepoStubFactory());
            //exercise
            BikeSearchResult result = handler.Execute(command) as BikeSearchResult;
            //verify
            Assert.IsNotNull(result, "Smoke test expects to return not null");
            //clenup
            RepositoryManager.RegisterFactory(null);
        }


        /// <summary>
        ///test method wich will pass if the method throws null
        /// for that we have to add ExpectedException(typeof(NullReferenceException) attribute
        /// and we dont use assets
        /// </summary>
        [TestMethod, ExpectedException(typeof(NullReferenceException))]
        public void ExecuteCommand_NullRepositoryFactory_ThrowsNullException_Test()
        {
            //setup
            RepositoryManager.RegisterFactory(null);
            BikeSearchCommandHandler handler = new BikeSearchCommandHandler();
            BikeSearchCommand command = new BikeSearchCommand();

            //exercise
            BikeSearchResult result = handler.Execute(command) as BikeSearchResult;


        }

      
    }

}


    public class BikeRepoTStub : IBikeRepository
    {
        public IList<Bike> SearchBike()
        {
            List<Bike> result = new List<Bike>();
            return result;
        }
        public Bike AddBike(Bike b)
        {
            return b;
        }
    }

    public class BikeRepoStubFactory : IRepositoryFactory
    {
        public TRepository CreateRepository<TRepository>() where TRepository : IRepository
        {
            BikeRepoTStub result = new BikeRepoTStub();
            return (TRepository)(object)result;
        }
    }


    public class Producer 
    {
        List<string> AllowedModel = new List<string>();
    public Producer()
    {
        AllowedModel.Add("CityBike");
        AllowedModel.Add("MountainBike");
    }
        
    }



