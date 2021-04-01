using DojoDDD.Domain.Core.Interfaces.Repositorys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DojoDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext sqlcontext;

        public RepositoryBase(SqlContext sqlcontext)
        {
            this.sqlcontext = sqlcontext;
        }

        public void Alterar(TEntity objeto)
        {
            try
            {
                sqlcontext.Entry(objeto).State = EntityState.Modified;
                sqlcontext.Set<TEntity>().Update(objeto);
                sqlcontext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(TEntity objeto)
        {
            try
            {
                sqlcontext.Set<TEntity>().Remove(objeto);
                sqlcontext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Incluir(TEntity objeto)
        {
            try
            {
                sqlcontext.Set<TEntity>().Add(objeto);
                sqlcontext.SaveChanges();
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        public TEntity ObterPorId(int id)
        {
            return sqlcontext.Set<TEntity>().Find(id);
        }

        public TEntity ObterPorId(string id)
        {
            return sqlcontext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return sqlcontext.Set<TEntity>().ToList();
        }
    }
}