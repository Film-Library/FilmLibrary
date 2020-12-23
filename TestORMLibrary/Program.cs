﻿namespace TestORMLibrary
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using Movies.NH.Repositories;
    using Movies.Services;

    internal class Program
    {
        internal static void Main(string[] args) => MainAsync(args).Wait();

        private static async Task MainAsync(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddConfigurationFromFile("appsettings.json");

            serviceCollection.AddNHibernateConfiguration("relative");
            serviceCollection.AddTransient<App>();
            serviceCollection.AddSingleton<IDirectorRepository, DirectorRepository>();
            serviceCollection.AddSingleton<IDirectorService, DirectorService>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            await serviceProvider.GetService<App>().Run();
            Console.WriteLine(true);

        }
    }
}
