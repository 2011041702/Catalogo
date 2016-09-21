using System;
using Catalogo.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebaUnitaria_RegistroAutor
    {
        [TestMethod]
        public void AutorRegistrado()
        {
            var lo_autor = Autor.RegistroAutor(1, "Javier Herveda","Drama", DateTime.Parse("17-12-2016"));
            Assert.IsNotNull(lo_autor);
            Assert.IsTrue(lo_autor.CodigoAutor == 1);
        }
    }
}
