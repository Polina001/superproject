namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inscription1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Picture = c.Binary(),
                        ThemeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Themes", t => t.ThemeID, cascadeDelete: true)
                .Index(t => t.ThemeID);
            
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
                        ThemeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Themes", t => t.ThemeID, cascadeDelete: true)
                .Index(t => t.ThemeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inscriptions", "ThemeID", "dbo.Themes");
            DropForeignKey("dbo.Images", "ThemeID", "dbo.Themes");
            DropIndex("dbo.Inscriptions", new[] { "ThemeID" });
            DropIndex("dbo.Images", new[] { "ThemeID" });
            DropTable("dbo.Inscriptions");
            DropTable("dbo.Themes");
            DropTable("dbo.Images");
        }
    }
}
