using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Dominio.Repositorios;
using Catalogo.Infraestructura.Contexto;

namespace Catalogo.Infraestructura.Repositorios
{
    public class RepositorioGenerico<T> : IRepositorio<T> where T : class
    {
        CatalogoContexto io_contexto;
        public IDbSet<T> Entidad { get; set; }
        public RepositorioGenerico(CatalogoContexto ao_contexto)
        {
            this.io_contexto = ao_contexto;
            this.Entidad = ao_contexto.Set<T>();
        }
        public RepositorioGenerico()
            : this(new CatalogoContexto("CatalogoConexion"))
        {
            //this.Entidad = System.Reflection.Assembly.GetAssembly(typeof(C)).CreateInstance(typeof(C));
        }

        public T ObtenerPorCodigo(params object[] ao_llaves)
        {
            return Entidad.Find(ao_llaves);
        }

        public IQueryable<T> Listar()
        {
            return Entidad;
        }

        public IList<T> ObtenerPorExpresion(Expression<Func<T, bool>> ao_llaves = null, string as_incluir = null, byte aby_limite = 0)
        {
            if (ao_llaves == null)
                return Entidad.ToList();
            else
                return Entidad.Where(ao_llaves).ToList();
        }
        public bool Adicionar(T ao_entidad)
        {
            Entidad.Add(ao_entidad);
            return true;
        }

        public bool Actualizar(T ao_entidad)
        {
            throw new NotImplementedException();
        }

        public bool GuardarCambios()
        {
            io_contexto.SaveChanges();
            return true;
        }
    }
}
