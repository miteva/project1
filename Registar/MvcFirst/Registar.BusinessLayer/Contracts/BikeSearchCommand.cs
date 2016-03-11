using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BusinessLayer.Contracts
{
    /// <summary>
    /// Class for Search Command for Bikes. Producer and Colour are  filters
    /// </summary>
    public class BikeSearchCommand : Command
    {
        public string Producer { set; get; }
        public string Colour { set; get; }
        public string City { set; get; }

        public int PageSize { set; get; }
        public int PageIndex { set; get; }

    }
}
