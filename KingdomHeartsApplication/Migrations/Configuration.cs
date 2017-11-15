namespace KingdomHeartsApplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using KingdomHeartsApplication.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<KingdomHeartsApplication.DAL.DB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KingdomHeartsApplication.DAL.DB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            KingdomHeartsGame Game1 = new KingdomHeartsGame
            {
                Title = "Kingdom Hearts",
                ReleaseDate = "2002"



            };
        }
    }
}
