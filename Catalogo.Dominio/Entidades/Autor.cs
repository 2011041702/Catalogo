using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Dominio
{
    public class Autor
    {
        public int CodigoAutor { get; set; }
        public string NombreAutor { get; set; }
        public string GeneroAutor { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Autor()
        {

        }

        public Autor(int codautor,string nombautor,string genautor,DateTime fechregist)
        {
            this.CodigoAutor = codautor;
            this.NombreAutor = nombautor;
            this.GeneroAutor = genautor;
            this.FechaRegistro = fechregist;
        }

        public static Autor RegistroAutor(int codautor, string nombautor, string genautor, DateTime fechregist)
        {
            return new Autor()
            {
                CodigoAutor = codautor,
                NombreAutor = nombautor,
                GeneroAutor = genautor,
                FechaRegistro = fechregist
            };
        }

        public void ModificarAutor(int codautor, string nombautor, string genautor, DateTime fechregist)
        {
                CodigoAutor = codautor;
                NombreAutor = nombautor;
                GeneroAutor = genautor;
                FechaRegistro = fechregist;
        }
    }
}
