using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Dominio
{
    public class Producto
    {
        public int CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }        
        public virtual Autor CodigoAutor { get; set; }        
        public virtual TipoProducto CodigoTipoProducto {get;set;}
        public string EstadoProducto { get; set; }


        public Producto(int codpro,string nombpro,string descpro,Autor codautor,TipoProducto codtipro,string estpro)
        {
            this.CodigoProducto = codpro;
            this.NombreProducto = nombpro;
            this.DescripcionProducto = descpro;
            this.CodigoAutor = codautor;
            this.CodigoTipoProducto = codtipro;
            this.EstadoProducto = estpro;
        }

        public Producto()
        {
        }

        public static Producto RegistrarProducto(int codpro, string nombpro, string descpro, Autor codautor, TipoProducto codtipro, string estpro)
        {
            return new Producto()
            {
                CodigoProducto = codpro,
                NombreProducto = nombpro,
                DescripcionProducto = descpro,
                CodigoAutor = codautor,
                CodigoTipoProducto = codtipro,
                EstadoProducto = estpro
            };
        }
        public void ModificarProducto(int codpro, string nombpro, string descpro, Autor codautor, TipoProducto codtipro, string estpro)
        {
            {
                CodigoProducto = codpro;
                NombreProducto = nombpro;
                DescripcionProducto = descpro;
                CodigoAutor = codautor;
                CodigoTipoProducto = codtipro;
                EstadoProducto = estpro;
            }
        }
    }
}
