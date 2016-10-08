namespace AspNetMVC_021_Action.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OBSContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fakulte",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false),
                        Sil = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fakulte");
        }
    }
}
