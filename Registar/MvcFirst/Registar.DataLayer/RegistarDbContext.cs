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
    /// Class that will help us to get out DbContext
    /// </summary>
   public class RegistarDbContext : DbContext
    {
       /// <summary>
       /// For now we have only one table Bikes in the database so we need only one DbSet Bikes
       /// </summary>
     public   DbSet<Bike> Bikes { set; get; }

       /// <summary>
       /// getting our context and fill the DbSet with the entries that are in the database
       /// </summary>
     public RegistarDbContext()
         : base("RegistarDb")
        {
            Bikes = this.Set<Bike>();
        }

       /// <summary>
       /// In the configurations we add our BikeCOnfiguration
       /// </summary>
       /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BikeConfiguration());
        }

    }
}
