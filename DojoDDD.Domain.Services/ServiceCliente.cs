using DojoDDD.Domain.Core.Interfaces.Repositorys;
using DojoDDD.Domain.Core.Interfaces.Services;
using DojoDDD.Domain.Entitys;

namespace DojoDDD.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente)
            : base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }
    }
}