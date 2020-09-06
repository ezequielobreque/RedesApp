namespace RedesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class activos : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Conexions", "activado", c => c.Boolean());
            AddColumn("public.Nodoes", "activado", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("public.Nodoes", "activado");
            DropColumn("public.Conexions", "activado");
        }
    }
}
