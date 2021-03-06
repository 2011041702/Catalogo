﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Dominio.Repositorios;
using Catalogo.Infraestructura.Contexto;

namespace Catalogo.Infraestructura.Repositorios
{
    public class RepositorioLectura<T> : IRepositorioLectura<T> where T : class
    {
        public IDbSet<T> Entidad { get; set; }
        public RepositorioLectura(CatalogoContexto ao_contexto)
        {
            this.Entidad = ao_contexto.Set<T>();
        }
        public RepositorioLectura()
            : this(new CatalogoContexto("CatalogoConexion"))
        {
            //this.Entidad = System.Reflection.Assembly.GetAssembly(typeof(C)).CreateInstance(typeof(C));
        }
        public T ObtenerPorCodigo(params object[] ao_llaves)
        {
            return Entidad.Find(ao_llaves);
        }

        public IList<T> ObtenerPorExpresion(System.Linq.Expressions.Expression<Func<T, bool>> ao_llaves, string as_incluir, byte aby_limite)
        {
            return Entidad.Where(ao_llaves).ToList();
        }

        public IQueryable<T> Listar()
        {
            return Entidad;
        }
    }
}
