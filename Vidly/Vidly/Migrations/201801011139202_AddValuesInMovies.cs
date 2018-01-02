namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValuesIns : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.s", "GenreId", c => c.Byte(nullable: false));
            AddColumn("dbo.s", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.s", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.s", "NumberInStock", c => c.Byte(nullable: false));
            AlterColumn("dbo.s", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.s", "GenreId");
            AddForeignKey("dbo.s", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.s", "GenreId", "dbo.Genres");
            DropIndex("dbo.s", new[] { "GenreId" });
            AlterColumn("dbo.s", "Name", c => c.String());
            DropColumn("dbo.s", "NumberInStock");
            DropColumn("dbo.s", "ReleaseDate");
            DropColumn("dbo.s", "DateAdded");
            DropColumn("dbo.s", "GenreId");
            DropTable("dbo.Genres");
        }
    }
}
