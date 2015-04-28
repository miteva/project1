using Registar.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DataLayer
{
    /// <summary>
    /// Configuration for Bike for database. Properties of Bike mapping into columns of table Bikes 
    /// </summary>
    public class BikeConfiguration :EntityTypeConfiguration<Bike>
    {

        public BikeConfiguration()
        {
            
            this.ToTable("Bikes","data").HasKey(p=>p.BikeId);
            this.Property(p => p.BikeId).HasColumnName("Id");
            this.Property(p => p.RegNumber).HasColumnName("RegNumber");
            this.Property(p => p.Prdoucer).HasColumnName("Producer");
            this.Property(p => p.Model).HasColumnName("Model");
            this.Property(p => p.Colour).HasColumnName("Colour");
            this.Property(p => p.City).HasColumnName("City");
            //this.Ignore(p => p.IgnoreMe);
        }
    }
}
