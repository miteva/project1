using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registar.BusinessLayer.Contracts;
using Registar.BusinessLayer.Handlers;
using Registar.Common;
using Registar.Common.Interfaces;
using Registar.DomainModel;
using Register.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BusinessLayer.Tests
{

    [TestClass]
    public class BikeRegisterHandlerUnitTest
    {


        [TestMethod]
        public void ExceuteCommand_NoExsistOwnerId_Test()
        {
            RepositoryManager.RegisterFactory(new BikeRepoStubFactory());
            AddBikeCommandHandler handler = new AddBikeCommandHandler();
            AddBikeCommand command = new AddBikeCommand();
            command.BikeToAdd = new Bike();
            //not valid owner ids are negative numbers
            command.BikeToAdd.BikeOwnerId = int.MinValue;

            AddBikeResult result = handler.Execute(command) as AddBikeResult;

            Assert.IsFalse(result.IsSuccesed, "For not valid owner id operation should be unsuccesfull");
            //StringAssert.Contains(result.Errors[0], "not valid ownerid", "For not valid owner id validation error is excepted");

        }



        [TestMethod]
        public void ExecuteAddBikeCommand_SmokeTest_NoException_Test()
        {
            //setup
            AddBikeCommandHandler handler = new AddBikeCommandHandler();
            AddBikeCommand command = new AddBikeCommand();
            RepositoryManager.RegisterFactory(new BikeRepoStubFactory());

            //exercise
            AddBikeResult result = handler.Execute(command) as AddBikeResult;

            //verify
            Assert.IsNotNull(result, "Smoke test expects to return not null");

            //clenup
            RepositoryManager.RegisterFactory(null);

        }

       

        //[TestMethod]
        //public void AddBikeCommand_CheckOwnerId_NoException_Test()
        //{
        //    AddBikeCommandHandler handler = new AddBikeCommandHandler();
        //    AddBikeCommand command = new AddBikeCommand();

        //    AddBikeResult result = handler.Execute(command) as AddBikeResult;
        //}



        //[TestMethod]
        //public void AddBikeCommand_CheckProducerModel_AllowedModelsForProduces_NoException()
        //{
        //    AddBikeCommandHandler handler = new AddBikeCommandHandler();
        //    AddBikeCommand command = new AddBikeCommand();

        //    AddBikeResult result = handler.Execute(command) as AddBikeResult;


        //    Assert.IsTrue(result.IsSuccesed,"Bike Model is valid for this Produces");


        //}



        //[TestMethod]
        //public void AddBikeCommand_CheckProducerModel_NotAllowedModelsForProduces_NoException()
        //{
        

           
        //}


        //[TestMethod]
        //public void AddBikeCommand_CheckUserID_NoException_Test()
        //{

        //}


        //[TestMethod]
        //public void AddBikeCommand_CheckUserName_NoException_Test()
        //{

        //}

        //[TestMethod]
        //public void AddBikeCommand_CheckUserPassword_NoException__Test()
        //{

        //}

        //[TestMethod]
        //public void AddBikeCommand_CheckUserEmail_NoException_Test()
        //{

        //}

    }

    //public class BikeToRegisterFactoryStub : IRepositoryFactory
    //{
    //    public static BikeRegisterRepoStub repo {set;get;}
    //    static public TRepository CreateRepository<TRepository>() where TRepository : IRepository
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public class BikeRegisterRepoStub : IBikeRepository
    {
        public Bike AddBike(Bike b)
        {
            throw new NotImplementedException();
        }

        public IList<Bike> SearchBike()
        {
            throw new NotImplementedException();
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


  
}
