using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Dominio
{
    public class Catalogo
    {
        public int CodigoCatalogo { get; set; }
        public string EdicionCatalogo { get; set; }
        public virtual Producto NombreProducto { get; set; }
        public virtual TipoProducto NombreTipoProducto { get; set; }
        public virtual Autor NombreAutor { get; set; }

        public Catalogo()
        {
        }

        public Catalogo(int codcata,string edicata,Producto nombpro, TipoProducto nombtipro, Autor nombautor)
        {
            this.CodigoCatalogo = codcata;
            this.EdicionCatalogo = edicata;
            this.NombreProducto = nombpro;
            this.NombreTipoProducto = nombtipro;
            this.NombreAutor = nombautor;
        }

        public static Catalogo RegistrarCatalogo(int codcata, string edicata, Producto nombpro, TipoProducto nombtipro, Autor nombautor)
        {
            return new Catalogo()
            {
                CodigoCatalogo = codcata,
                EdicionCatalogo = edicata,
                NombreProducto = nombpro,
                NombreTipoProducto = nombtipro,
                NombreAutor = nombautor
            };
        }

        public void ModificarCatalogo(int codcata, string edicata, Producto nombpro, TipoProducto nombtipro, Autor nombautor)
        {
                CodigoCatalogo = codcata;
                EdicionCatalogo = edicata;
                NombreProducto = nombpro;
                NombreTipoProducto = nombtipro;
                NombreAutor = nombautor;
        }
    }
}
