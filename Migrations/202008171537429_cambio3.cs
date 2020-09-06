namespace RedesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambio3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("public.Conexions", "velocidad", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("public.Conexions", "velocidad", c => c.Double(nullable: false));
        }
    }
}
