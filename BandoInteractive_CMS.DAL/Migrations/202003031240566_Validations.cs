namespace BandoInteractive_CMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Layouts", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Layouts", "Path", c => c.String(nullable: false));
            AlterColumn("dbo.Pages", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Pages", "Content", c => c.String(nullable: false));
            AlterColumn("dbo.Pages", "URL", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pages", "URL", c => c.String());
            AlterColumn("dbo.Pages", "Content", c => c.String());
            AlterColumn("dbo.Pages", "Name", c => c.String());
            AlterColumn("dbo.Layouts", "Path", c => c.String());
            AlterColumn("dbo.Layouts", "Name", c => c.String());
        }
    }
}
