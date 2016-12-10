namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Image1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Images", "IDTheme");
            DropColumn("dbo.Inscriptions", "IDTheme");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Inscriptions", "IDTheme", c => c.Int(nullable: false));
            AddColumn("dbo.Images", "IDTheme", c => c.Int(nullable: false));
        }
    }
}
