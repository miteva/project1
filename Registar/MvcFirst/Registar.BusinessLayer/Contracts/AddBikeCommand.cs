using Registar.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BusinessLayer.Contracts
{
   public class AddBikeCommand : Command
    {
       public  Bike BikeToAdd{set;get;}
    }
}
