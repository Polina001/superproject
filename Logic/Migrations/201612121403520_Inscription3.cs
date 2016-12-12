namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inscription3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Inscriptions", "ThemeID", "dbo.Themes");
            DropIndex("dbo.Inscriptions", new[] { "ThemeID" });
            RenameColumn(table: "dbo.Inscriptions", name: "ThemeID", newName: "Theme_ID");
            AlterColumn("dbo.Inscriptions", "Theme_ID", c => c.Int());
            CreateIndex("dbo.Inscriptions", "Theme_ID");
            AddForeignKey("dbo.Inscriptions", "Theme_ID", "dbo.Themes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inscriptions", "Theme_ID", "dbo.Themes");
            DropIndex("dbo.Inscriptions", new[] { "Theme_ID" });
            AlterColumn("dbo.Inscriptions", "Theme_ID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Inscriptions", name: "Theme_ID", newName: "ThemeID");
            CreateIndex("dbo.Inscriptions", "ThemeID");
            AddForeignKey("dbo.Inscriptions", "ThemeID", "dbo.Themes", "ID", cascadeDelete: true);
        }
    }
}
