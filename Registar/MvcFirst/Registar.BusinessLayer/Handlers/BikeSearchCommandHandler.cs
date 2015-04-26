using Registar.BusinessLayer.Contracts;
using Registar.DataLayer;
using Registar.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BusinessLayer.Handlers
{
    /// <summary>
    /// Class for Handling the Search Command for Bikes, inherits from generic class CommandHandlerBase
    /// </summary>
    internal class BikeSearchCommandHandler : CommandHandlerBase<BikeSearchCommand, BikeSearchResult>

    {
      
        /// <summary>
        /// override the base function ExecuteCommand, returns List of bikes that correspond to the search command
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        protected override BikeSearchResult ExecuteCommand(BikeSearchCommand command)
        {
           
                BikeSearchResult _result = new BikeSearchResult();
                List<Bike> bikes = new List<Bike>();
                IContextTable table=new BikeContextTable();
                bikes = table.GetTableFromContext<Bike>();

                 if (command.Colour != null) {

                     foreach (Bike b in bikes) 
                     {
                         if (b.Colour == command.Colour)
                             _result.Result.Add(b);
                     }
                 }
                 if (command.Producer != null)
                 {

                     foreach (Bike b in bikes)
                     {
                         if (b.Prdoucer == command.Producer)
                             _result.Result.Add(b);
                     }
                 }
               

                return _result;
            }
               
         
        }
    }

