namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Image2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Images", "Theme_ID", "dbo.Themes");
            DropForeignKey("dbo.Inscriptions", "Theme_ID", "dbo.Themes");
            DropIndex("dbo.Images", new[] { "Theme_ID" });
            DropIndex("dbo.Inscriptions", new[] { "Theme_ID" });
            RenameColumn(table: "dbo.Images", name: "Theme_ID", newName: "ThemeID");
            RenameColumn(table: "dbo.Inscriptions", name: "Theme_ID", newName: "ThemeID");
            AlterColumn("dbo.Images", "ThemeID", c => c.Int(nullable: false));
            AlterColumn("dbo.Inscriptions", "ThemeID", c => c.Int(nullable: false));
            CreateIndex("dbo.Images", "ThemeID");
            CreateIndex("dbo.Inscriptions", "ThemeID");
            AddForeignKey("dbo.Images", "ThemeID", "dbo.Themes", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Inscriptions", "ThemeID", "dbo.Themes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inscriptions", "ThemeID", "dbo.Themes");
            DropForeignKey("dbo.Images", "ThemeID", "dbo.Themes");
            DropIndex("dbo.Inscriptions", new[] { "ThemeID" });
            DropIndex("dbo.Images", new[] { "ThemeID" });
            AlterColumn("dbo.Inscriptions", "ThemeID", c => c.Int());
            AlterColumn("dbo.Images", "ThemeID", c => c.Int());
            RenameColumn(table: "dbo.Inscriptions", name: "ThemeID", newName: "Theme_ID");
            RenameColumn(table: "dbo.Images", name: "ThemeID", newName: "Theme_ID");
            CreateIndex("dbo.Inscriptions", "Theme_ID");
            CreateIndex("dbo.Images", "Theme_ID");
            AddForeignKey("dbo.Inscriptions", "Theme_ID", "dbo.Themes", "ID");
            AddForeignKey("dbo.Images", "Theme_ID", "dbo.Themes", "ID");
        }
    }
}
