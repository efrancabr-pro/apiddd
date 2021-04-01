using DojoDDD.Domain.Core.Interfaces.Repositorys;
using DojoDDD.Domain.Core.Interfaces.Services;
using DojoDDD.Domain.Entitys;

namespace DojoDDD.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto)
            : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}