using System.Data.Entity.Migrations;

namespace RedesApp.Migrations
{

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Conexions",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Address = c.String(),
                    Nodo1Id = c.Int(nullable: false),
                    Nodo2Id = c.Int(nullable: false),
                    Nodo_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Nodoes", t => t.Nodo_Id)
                .ForeignKey("public.Nodoes", t => t.Nodo1Id, cascadeDelete: true)
                .ForeignKey("public.Nodoes", t => t.Nodo2Id, cascadeDelete: true)
                .Index(t => t.Nodo1Id)
                .Index(t => t.Nodo2Id)
                .Index(t => t.Nodo_Id);

            CreateTable(
                "public.Nodoes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Nombre = c.String(),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropForeignKey("public.Conexions", "Nodo2Id", "public.Nodoes");
            DropForeignKey("public.Conexions", "Nodo1Id", "public.Nodoes");
            DropForeignKey("public.Conexions", "Nodo_Id", "public.Nodoes");
            DropIndex("public.Conexions", new[] { "Nodo_Id" });
            DropIndex("public.Conexions", new[] { "Nodo2Id" });
            DropIndex("public.Conexions", new[] { "Nodo1Id" });
            DropTable("public.Nodoes");
            DropTable("public.Conexions");
        }
    }
}
