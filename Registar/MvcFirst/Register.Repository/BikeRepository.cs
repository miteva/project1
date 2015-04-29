using Register.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.DomainModel;
using Registar.DataLayer;
using Registar.Common;
using System.Diagnostics;
using Autofac;
using Registar.Common.Interfaces;

namespace Register.Repository
{
    
    // public class BikeRepository : IBikeRepository,IRepository
    /// <summary>
    /// if we want to create repositoryfactory with autofac we have to use the commented lines above the summary.
    /// This class will help us to connect with the database
    /// </summary>
    public class BikeRepository : IBikeRepository
    {

        public IList<Bike> SearchBike()
        {
            Logging.LogWarn("====BikeSearchTestILogger====");


            IContainer Container = RegisterComponents.RegisterAllComponents();
            using (var scope = Container.BeginLifetimeScope())
            {
                //creating context using autofac
                var context = Container.Resolve<IRegistarContext>();
                return context.Bikes.ToList();

            }
        }

            public Bike AddBike(Bike b)
            {
            IContainer Container = RegisterComponents.RegisterAllComponents();
            
            using (var scope = Container.BeginLifetimeScope())
            {
                //creating context using autofac
                RegistarDbContext context = (RegistarDbContext)Container.Resolve<IRegistarContext>();
                
                context.Bikes.Add(b);
                context.SaveChanges();

                return context.Bikes.FirstOrDefault(x => x.BikeId == b.BikeId);


            }

        }
        }
    }


