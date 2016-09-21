using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Dominio
{
    public class TipoProducto
    {
        public int CodigoTipoProducto { get; set; }
        public string NombreTipoProducto { get; set; }
        public string DescripcionTipoProducto { get; set; }
        public string EstadoTipoProducto { get; set; }

        public TipoProducto(int codtipro,string nombtipro,string descpro,string estpro)
        {
            this.CodigoTipoProducto = codtipro;
            this.NombreTipoProducto = nombtipro;
            this.DescripcionTipoProducto = descpro;
            this.EstadoTipoProducto = estpro;            
        }
        public TipoProducto()
        {

        }
        public static TipoProducto RegistrarTipoProducto(int codtipro, string nombtipro, string descpro, string estpro)
        {
            return new TipoProducto()
            {
                CodigoTipoProducto = codtipro,
                NombreTipoProducto = nombtipro,
                DescripcionTipoProducto = descpro,                
                EstadoTipoProducto = estpro
            };
        }
        public void ModificarTipoProducto(int codtipro, string nombtipro, string descpro, string estpro)
        {
            {
                CodigoTipoProducto = codtipro;
                NombreTipoProducto = nombtipro;
                DescripcionTipoProducto = descpro;
                EstadoTipoProducto = estpro;
            }
        }
    }
}
