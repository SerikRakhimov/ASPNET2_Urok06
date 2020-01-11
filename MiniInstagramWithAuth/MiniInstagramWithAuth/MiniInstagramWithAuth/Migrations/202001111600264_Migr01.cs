namespace MiniInstagramWithAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migr01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Text = c.String(),
                        Url = c.String(),
                        Likes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts");
        }
    }
}
