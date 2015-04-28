using Registar.Common.Interfaces;
using Registar.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Register.Repository.Interfaces
{
    /// <summary>
    /// this interface is used for mapping into BikeRepository
    /// </summary>
    public interface IBikeRepository : IRepository
    {
        IList<Bike> SearchBike();
    }
}
