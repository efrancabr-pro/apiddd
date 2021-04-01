using DojoDDD.Application.Dtos;
using DojoDDD.Application.Interfaces;
using DojoDDD.Application.Interfaces.Mappers;
using DojoDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente serviceCliente;
        private readonly IMapperCliente mapperCliente;

        public ApplicationServiceCliente(IServiceCliente serviceCliente
                                         , IMapperCliente mapperCliente)
        {
            this.mapperCliente = mapperCliente;
            this.serviceCliente = serviceCliente;
        }

        public void Alterar(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Alterar(cliente);
        }

        public void Excluir(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Excluir(cliente);
        }

        public void Incluir(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Incluir(cliente);
        }

        public ClienteDto ObterPorId(int id)
        {
            var cliente = serviceCliente.ObterPorId(id);
            return mapperCliente.MapperEntityToDto(cliente);
        }

        public IEnumerable<ClienteDto> ObterTodos()
        {
            var clientes = serviceCliente.ObterTodos();
            return mapperCliente.MapperListClientesDto(clientes);
        }

        async Task<ClienteDto> IApplicationServiceCliente.ObterPorId(int id)
        {
            var cliente = serviceCliente.ObterPorId(id);
            return await Task.FromResult(mapperCliente.MapperEntityToDto(cliente)).ConfigureAwait(false) ;
        }

        async Task<IEnumerable<ClienteDto>> IApplicationServiceCliente.ObterTodos()
        {
            var clientes = serviceCliente.ObterTodos();
            return await Task.FromResult(mapperCliente.MapperListClientesDto(clientes)).ConfigureAwait(false) ;
        }
    }
}