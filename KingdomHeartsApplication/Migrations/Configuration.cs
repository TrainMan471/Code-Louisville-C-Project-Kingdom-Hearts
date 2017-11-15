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
                ReleaseDate = 2002
            };

            KingdomHeartsGame Game2 = new KingdomHeartsGame
            {
                Title = "Kingdom Hearts: Chain of Memories",
                ReleaseDate = 2004
            };

            KingdomHeartsGame Game3 = new KingdomHeartsGame
            {
                Title = "Kingdom Hearts 2",
                ReleaseDate = 2005
            };

            context.KingdomHeartsGames.AddOrUpdate(KingdomHeartsGame => KingdomHeartsGame.Title, Game1, Game2, Game3);

            context.KingdomHeartsReviews.AddOrUpdate(KingdomHeartsReview => KingdomHeartsReview.Username,
                new KingdomHeartsReview() { Username = "Trainman471", FavoriteGame = "Kingdom Hearts 358/2 Days", HighestDifficulty = "Critical", Rating =8 }); 





   
        }
    }

       
    }
