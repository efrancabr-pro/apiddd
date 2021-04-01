using DojoDDD.Domain.Core.Interfaces.Repositorys;
using DojoDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace DojoDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Alterar(TEntity objeto)
        {
            repository.Alterar(objeto);
        }

        public void Excluir(TEntity objeto)
        {
            repository.Excluir(objeto);
        }

        public void Incluir(TEntity objeto)
        {
            repository.Incluir(objeto);
        }

        public TEntity ObterPorId(int id)
        {
            return repository.ObterPorId(id);
        }

        public TEntity ObterPorId(string id)
        {
            return repository.ObterPorId(id);
        }


        public IEnumerable<TEntity> ObterTodos()
        {
            return repository.ObterTodos();
        }
    }
}