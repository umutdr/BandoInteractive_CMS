namespace BandoInteractive_CMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Layouts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Content = c.String(),
                        URL = c.String(),
                        LayoutId = c.Int(nullable: false),
                        ParentPageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Layouts", t => t.LayoutId, cascadeDelete: true)
                .ForeignKey("dbo.Pages", t => t.ParentPageId)
                .Index(t => t.LayoutId)
                .Index(t => t.ParentPageId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pages", "ParentPageId", "dbo.Pages");
            DropForeignKey("dbo.Pages", "LayoutId", "dbo.Layouts");
            DropIndex("dbo.Pages", new[] { "ParentPageId" });
            DropIndex("dbo.Pages", new[] { "LayoutId" });
            DropTable("dbo.Pages");
            DropTable("dbo.Layouts");
        }
    }
}
