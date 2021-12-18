using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using InlämningsuppgiftKennel.Customers;
using InlämningsuppgiftKennel.Data;
using InlämningsuppgiftKennel.Dog;
using InlämningsuppgiftKennel.Menu;
using InlämningsuppgiftKennel.Factories;

namespace InlämningsuppgiftKennel
{
    public static class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register Main Application
            builder.RegisterType<Application>().As<IApplication>();


            // Register one by one
            builder.RegisterType<MainMenu>().As<IMainMenu>();
            builder.RegisterType<AnimalManager>().As<IAnimalManager>();
            builder.RegisterType<CustomerManager>().As<ICustomerManager>();
            builder.RegisterType<Customer>().As<ICustomer>();
            builder.RegisterType<Animal>().As<IAnimal>();
            builder.RegisterType<CustomerFactory>().As<ICustomerFactory>();
            builder.RegisterType<AnimalFactory>().As<IAnimalFactory>();

            // Data
            builder.RegisterType<DataBaseUsingLists>().As<IDataBaseUsingLists>().SingleInstance();

            //Repository
            builder.RegisterType<DataRepository>().As<IDataRepository>();

            return builder.Build();

        }
    }
}
