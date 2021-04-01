using Autofac;
using DojoDDD.Application;
using DojoDDD.Application.Interfaces.Mappers;
using DojoDDD.Application.Mappers;
using DojoDDD.Domain.Core.Interfaces.Repositorys;
using DojoDDD.Domain.Core.Interfaces.Services;
using DojoDDD.Domain.Services;
using DojoDDD.Infrastructure.Data.Repositorys;

namespace DojoDDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationServiceCliente>().As<ApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<ApplicationServiceProduto>();
            builder.RegisterType<ApplicationServiceOrdemCompra>().As<ApplicationServiceOrdemCompra>();
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<ServiceOrdemCompra>().As<IServiceOrdemCompra>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<RepositoryOrdemCompra>().As<IRepositoryOrdemCompra>();
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();
            builder.RegisterType<MapperOrdemCompra>().As<IMapperOrdemCompra>();
        }
    }
}