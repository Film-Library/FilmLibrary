namespace Infrastructure.Helpers
{
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using NHibernate;
    using System.Reflection;

    /// <summary>
    /// настройки NHibernate.
    /// </summary>
    public static class NHibernateConfigurator
    {
        
        public static string DataSourceLocation = @"C:\ ";

        private static string GetConnectionString() => $"Data Source={DataSourceLocation};Version=3;UTF8Encoding=True;";

        private static FluentConfiguration config;

        public static FluentConfiguration GetConfiguration(Assembly assembly, bool showSql = false)
        {
            var configuration = SQLiteConfiguration.Standard.ConnectionString(GetConnectionString());
            if (showSql)
            {
                configuration = configuration.ShowSql().FormatSql();
            }

            return config = Fluently.Configure()
                .Database(configuration)
                .Mappings(m => m
                    .FluentMappings.AddFromAssembly(assembly)
            //.Conventions.AddAssembly(Assembly.GetExecutingAssembly()));
            //.Conventions.Add<MyIdConvention>()
            //.Conventions.Add<MyForeignKeyConvention>()
            //.Conventions.Add<MyManyToManyTableNameConvention>());
                );
        }

        public static ISessionFactory GetSessionFactory() => config?.BuildSessionFactory();
    }
}