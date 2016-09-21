using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Infraestructura.Contexto
{
    public class InicializadorBD : CreateDatabaseIfNotExists<CatalogoContexto>
    {
        protected override void Seed(CatalogoContexto context)
        {
            base.Seed(context);
        }
    }
}
