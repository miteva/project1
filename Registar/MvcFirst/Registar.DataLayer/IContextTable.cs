using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DataLayer
{
    /// <summary>
    /// Interface that has generic method. In order that we have more than one table, we can create this kind of interface
    /// and call the method with the type of Table(TTable can be Bike,
    /// if we have User class, TTable can be User and we will get Users table from database)
    /// </summary>
    public interface IContextTable
    {
        List<TTable> GetTableFromContext<TTable>();
    }
}
