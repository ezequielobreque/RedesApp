namespace RedesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambio4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Conexions", "distancia", c => c.Int(nullable: false));
            DropColumn("public.Conexions", "velocidad");
        }
        
        public override void Down()
        {
            AddColumn("public.Conexions", "velocidad", c => c.Int(nullable: false));
            DropColumn("public.Conexions", "distancia");
        }
    }
}
