namespace MvcAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogPosts",
                c => new
                    {
                        BlogPostId = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 300),
                        Content = c.String(),
                        PublishedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BlogPostId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BlogPosts");
        }
    }
}
