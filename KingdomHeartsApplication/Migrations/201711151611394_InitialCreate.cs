namespace KingdomHeartsApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            //Creating The tables for Kingdom Hearts Game and Kingdom Hearts Review Models; Even though Kingdom Hearts Game Model is never actually used.
            CreateTable(
                "dbo.KingdomHeartsGame",
                c => new
                    {
                        Title = c.String(nullable: false, maxLength: 128),
                        Description = c.String(),
                        PlayableCharacter = c.String(),
                        ReleaseDate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Title);
            
            CreateTable(
                "dbo.KingdomHeartsReview",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        HighestDifficulty = c.String(),
                        FavoriteGame = c.String(),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Username);
            
            CreateTable(
                "dbo.KingdomHeartsReviewKingdomHeartsGame",
                c => new
                    {
                        KingdomHeartsReview_Username = c.String(nullable: false, maxLength: 128),
                        KingdomHeartsGame_Title = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.KingdomHeartsReview_Username, t.KingdomHeartsGame_Title })
                .ForeignKey("dbo.KingdomHeartsReview", t => t.KingdomHeartsReview_Username, cascadeDelete: true)
                .ForeignKey("dbo.KingdomHeartsGame", t => t.KingdomHeartsGame_Title, cascadeDelete: true)
                .Index(t => t.KingdomHeartsReview_Username)
                .Index(t => t.KingdomHeartsGame_Title);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KingdomHeartsReviewKingdomHeartsGame", "KingdomHeartsGame_Title", "dbo.KingdomHeartsGame");
            DropForeignKey("dbo.KingdomHeartsReviewKingdomHeartsGame", "KingdomHeartsReview_Username", "dbo.KingdomHeartsReview");
            DropIndex("dbo.KingdomHeartsReviewKingdomHeartsGame", new[] { "KingdomHeartsGame_Title" });
            DropIndex("dbo.KingdomHeartsReviewKingdomHeartsGame", new[] { "KingdomHeartsReview_Username" });
            DropTable("dbo.KingdomHeartsReviewKingdomHeartsGame");
            DropTable("dbo.KingdomHeartsReview");
            DropTable("dbo.KingdomHeartsGame");
        }
    }
}
