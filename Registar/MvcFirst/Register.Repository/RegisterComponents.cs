using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Register.Repository;
using Register.Repository.Interfaces;
using Registar.DataLayer;
using Registar.Common.Interfaces;

namespace Register.Repository
{
    /// <summary>
    /// class where we register all the components in the autofac
    /// </summary>
   public class RegisterComponents
    {
       private static IContainer Container { get; set; }

      public static IContainer RegisterAllComponents()
       {
           var builder = new ContainerBuilder();
          
          //TODO if we want to create factoryrepository with autofac we have to use commented line
           //builder.RegisterType<BikeRepository>().As<IRepository>();
          //TODO with this line IBikeRepository is mapping in BikeRepository 
           builder.RegisterType<BikeRepository>().As<IBikeRepository>();
           builder.RegisterType<RegistarDbContext>().As<IRegistarContext>();
          // builder.RegisterType<DefaultRepositoryFactory>().As<IRepositoryFactory>();

           Container = builder.Build();
         
           return Container;
       }

    }
}
