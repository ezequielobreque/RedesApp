namespace RedesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambio2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("public.Conexions", "Nodo_Id", "public.Nodoes");
            DropIndex("public.Conexions", new[] { "Nodo_Id" });
            AddColumn("public.Nodoes", "nodo", c => c.Int(nullable: false));
            DropColumn("public.Conexions", "Nodo_Id");
            DropColumn("public.Nodoes", "Nombre");
        }
        
        public override void Down()
        {
            AddColumn("public.Nodoes", "Nombre", c => c.String());
            AddColumn("public.Conexions", "Nodo_Id", c => c.Int());
            DropColumn("public.Nodoes", "nodo");
            CreateIndex("public.Conexions", "Nodo_Id");
            AddForeignKey("public.Conexions", "Nodo_Id", "public.Nodoes", "Id");
        }
    }
}
