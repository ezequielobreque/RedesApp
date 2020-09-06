namespace RedesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambioencolumna : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Conexions", "velocidad", c => c.Double(nullable: false));
            DropColumn("public.Conexions", "Address");
        }
        
        public override void Down()
        {
            AddColumn("public.Conexions", "Address", c => c.String());
            DropColumn("public.Conexions", "velocidad");
        }
    }
}
