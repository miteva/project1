using Registar.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BusinessLayer.Contracts
{
    public class AddBikeResult : CommandResult
    {
        public Bike Bike { set; get; }
        public List<string> Errors = new List<string>();
        public bool IsSuccesed = false;
    }
}
