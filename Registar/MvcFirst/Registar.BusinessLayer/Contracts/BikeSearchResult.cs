using Registar.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BusinessLayer.Contracts
{
    /// <summary>
    /// Class for result from Bike Search Command
    /// </summary>
   public class BikeSearchResult : CommandResult
    {
        public List<Bike> Result { set; get; }

        public BikeSearchResult()
        {
            Result = new List<Bike>();
        }
    }
}
