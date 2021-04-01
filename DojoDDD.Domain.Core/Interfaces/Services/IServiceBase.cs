using System.Collections.Generic;

namespace DojoDDD.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Incluir(TEntity objeto);

        void Alterar(TEntity objeto);

        void Excluir(TEntity objeto);

        TEntity ObterPorId(int id);

        TEntity ObterPorId(string id);

        IEnumerable<TEntity> ObterTodos();
    }
}