namespace DAL.Migrations
{
    using DbCont;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.DbCont.LokantaContext>
    {
        public Configuration()
        {
           
            //AutomaticMigrationsEnabled = false;

            //tablolarda veri varken güncelleme yapmak için     
           // AutomaticMigrationDataLossAllowed = true;
            ContextKey = "DAL.DbCont.LokantaContext";
        }

        protected override void Seed(DAL.DbCont.LokantaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
