using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KingdomHeartsApplication;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using KingdomHeartsApplication.Models;

namespace KingdomHeartsApplication.DAL
{
    public class DB : DbContext
    {
        public DB() : base("DB")
        {

        }
        public DbSet<KingdomHeartsGame> KingdomHeartsGames { get; set; }
        public DbSet<KingdomHeartsReview> KingdomHeartsReviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}