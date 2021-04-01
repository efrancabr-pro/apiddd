using DojoDDD.Domain.Core.Interfaces.Repositorys;
using DojoDDD.Domain.Entitys;

namespace DojoDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryOrdemCompra : RepositoryBase<OrdemCompra>, IRepositoryOrdemCompra
    {
        private readonly SqlContext sqlContext;

        public RepositoryOrdemCompra(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}