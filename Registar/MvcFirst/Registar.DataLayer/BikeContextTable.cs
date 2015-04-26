using Registar.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DataLayer
{
    /// <summary>
    /// Class for getting the context from database
    /// </summary>
    public class BikeContextTable : IContextTable
    {
        /// <summary>
        /// Private method for getting the table Bikes from RegistarDbContext
        /// </summary>
        /// <returns></returns>
        private static List<Bike> GetTable() 
        {
            using (RegistarDbContext context = new RegistarDbContext()) 
            {
                
                    return context.Bikes.ToList();
            }
        }


        /// <summary>
        /// Public generic method, implements the interface IContextTable for getting the table Bikes
        /// </summary>
        /// <typeparam name="TTable"></typeparam>
        /// <returns></returns>
        public List<TTable> GetTableFromContext<TTable>()
        {
            using (RegistarDbContext context = new RegistarDbContext())
            {

               
                    return GetTable() as List<TTable>;

                
                

            }
        }
    }
}
