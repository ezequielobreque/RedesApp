using System.Data.Entity;

namespace RedesApp
{

    public class DBcontext : DbContext
    {

        public DbSet<Nodo> Nodo { get; set; }


        public DbSet<Conexion> Conexion { get; set; }
        public DBcontext() : base(nameOrConnectionString: "DBredes") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }


    }
}
