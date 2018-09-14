using NPoco;
using NPoco.FluentMappings;
using NpocoOutOfMemoryApp.Mapping;
using NpocoOutOfMemoryApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpocoOutOfMemoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseFactoryConfigOptions options = new DatabaseFactoryConfigOptions();

            options.Database = () => new NPoco.Database("host=marspostgresql.postgres.database.azure.com;user id=middleware_user@marspostgresql;password=I @m a 1itt1e t@apot;database=marsworxpoc;ApplicationName=Marsworx Middleware", DatabaseType.PostgreSQL, Npgsql.NpgsqlFactory.Instance);//

            options.PocoDataFactory = FluentMappingConfiguration.Configure(
                new ParentMap()
              , new ChildMap()
              , new OtherChildMap()
              , new IntermediateMap()
            );

           var databaseFactory = new DatabaseFactory(options);

            using (var db = databaseFactory.GetDatabase()) {
                var result = db.Query<Parent>().Count();
            }
        }
    }
}
