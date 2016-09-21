using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Dominio;

namespace Catalogo.Infraestructura.Contexto
{
    public class CatalogoContexto : DbContext, IDisposable
    {
        //ERRORES
        //int A;
        public CatalogoContexto(string Conexion) : base("Conexion")
        {
            Database.SetInitializer<CatalogoContexto>(new InicializadorBD());
        }
        public CatalogoContexto() : base("CatalogoConexion")
        {
        }

        public DbSet<Autor> Autor { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<TipoProducto> TipoProducto { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Autor>().HasKey(k => k.CodigoAutor);
            modelBuilder.Entity<Producto>().HasKey(k => k.CodigoProducto);
            modelBuilder.Entity<TipoProducto>().HasKey(k => k.CodigoTipoProducto);            
            ///mapera llaves foraneas
            /// identity
        }
    }
}
