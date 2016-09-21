using System;
using Catalogo.Dominio;
using Catalogo.Infraestructura.Contexto;
using Catalogo.Infraestructura.Repositorios;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebaIntegral_RegistroAutor
    {
        [TestMethod]
        public void AgregarCliente()
        {
            var lo_autor = Autor.RegistroAutor(1, "Javier Herveda", "Drama", DateTime.Parse("17-12-2016"));

            var lo_rep_autor = new RepositorioGenerico<Autor>();

            using (var lo_contexto = new CatalogoContexto())
            {
                lo_contexto.Autor.Add(lo_autor);
                lo_contexto.SaveChanges();
            }
            //Assert.IsTrue(lo_autor.CodigoAutor == 2);

           /* Cargo cargo = new Cargo(3, "Recepcionista", "Encargado de la atencion del huesped", 899, "aceptado");
            
            var lo_rep_cargo = new RepositorioGenerico<Cargo>();
            
            using (var lo_contexto = new HoteleraContexto())
            {
                
                lo_contexto.Cargos.Add(cargo);
                lo_contexto.SaveChanges();
            }*/
        }
    }
}
