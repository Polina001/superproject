namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Picture = c.Binary(),
                        IDTheme = c.Int(nullable: false),
                        Theme_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Themes", t => t.Theme_ID)
                .Index(t => t.Theme_ID);
            
            CreateTable(
                "dbo.Themes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ThemeName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Inscriptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InscriptionText = c.Binary(),
                        IDTheme = c.Int(nullable: false),
                        Theme_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Themes", t => t.Theme_ID)
                .Index(t => t.Theme_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inscriptions", "Theme_ID", "dbo.Themes");
            DropForeignKey("dbo.Images", "Theme_ID", "dbo.Themes");
            DropIndex("dbo.Inscriptions", new[] { "Theme_ID" });
            DropIndex("dbo.Images", new[] { "Theme_ID" });
            DropTable("dbo.Inscriptions");
            DropTable("dbo.Themes");
            DropTable("dbo.Images");
        }
    }
}
