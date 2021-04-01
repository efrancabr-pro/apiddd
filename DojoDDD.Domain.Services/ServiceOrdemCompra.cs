using DojoDDD.Domain.Core.Interfaces.Repositorys;
using DojoDDD.Domain.Core.Interfaces.Services;
using DojoDDD.Domain.Entitys;

namespace DojoDDD.Domain.Services
{
    public class ServiceOrdemCompra : ServiceBase<OrdemCompra>, IServiceOrdemCompra
    {
        private readonly IRepositoryOrdemCompra repositoryOrdemCompra;

        public ServiceOrdemCompra(IRepositoryOrdemCompra repositoryOrdemCompra) : base(repositoryOrdemCompra)
        {
            this.repositoryOrdemCompra = repositoryOrdemCompra;
        }
    }
}