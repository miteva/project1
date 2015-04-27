using Register.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.DomainModel;
using Registar.DataLayer;
using Registar.Common;

namespace Register.Repository
{
    internal class BikeRepository : IBikeRepository
    {
      //  Logging.LogError("====BikeSearc====");
        public IList<Bike> SearchBike()
        {
            var context = DataContextManager.CreateContext<IRegistarContext>();
            {
                return context.Bikes.ToList();
            }
        }
    }
}
