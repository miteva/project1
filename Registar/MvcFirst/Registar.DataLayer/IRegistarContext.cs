using Registar.Common.Interfaces;
using Registar.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DataLayer
{
    public interface IRegistarContext : IDataContextRepository
    {
        DbSet<Bike> Bikes { set; get; }
    }
}
