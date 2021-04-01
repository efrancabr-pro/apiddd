using DojoDDD.Application.Dtos;
using DojoDDD.Application.Interfaces;
using DojoDDD.Application.Interfaces.Mappers;
using DojoDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Application
{
    public class ApplicationServiceOrdemCompra : IApplicationServiceOrdemCompra
    {
        private readonly IServiceOrdemCompra serviceOrdemCompra;
        private readonly IMapperOrdemCompra mapperOrdemCompra;

        public ApplicationServiceOrdemCompra(IServiceOrdemCompra serviceOrdemCompra
                                     , IMapperOrdemCompra mapperOrdemCompra)
        {
            this.serviceOrdemCompra = serviceOrdemCompra;
            this.mapperOrdemCompra = mapperOrdemCompra;
        }

        public void Alterar(OrdemCompraDto ordemCompraDto)
        {
            var ordemCompra = mapperOrdemCompra.MapperDtoToEntity(ordemCompraDto);
            serviceOrdemCompra.Alterar(ordemCompra);
        }

        public void Excluir(OrdemCompraDto ordemCompraDto)
        {
            var ordemCompra = mapperOrdemCompra.MapperDtoToEntity(ordemCompraDto);
            serviceOrdemCompra.Excluir(ordemCompra);
        }

        public void Incluir(OrdemCompraDto ordemCompraDto)
        {
            var ordemCompra = mapperOrdemCompra.MapperDtoToEntity(ordemCompraDto);
            serviceOrdemCompra.Incluir(ordemCompra);
        }

        public OrdemCompraDto ObterPorId(string id)
        {
            var ordemCompra = serviceOrdemCompra.ObterPorId(id);
            return mapperOrdemCompra.MapperEntityToDto(ordemCompra);
        }

        public IEnumerable<OrdemCompraDto> ObterTodos()
        {
            var ordensCompra = serviceOrdemCompra.ObterTodos();
            return mapperOrdemCompra.MapperListOrdensCompraDto(ordensCompra);
        }

        async Task<OrdemCompraDto> IApplicationServiceOrdemCompra.ObterPorId(string id)
        {
            var ordemCompra = serviceOrdemCompra.ObterPorId(id);
            return await Task.FromResult( mapperOrdemCompra.MapperEntityToDto(ordemCompra)).ConfigureAwait(false);
        }

        async Task<IEnumerable<OrdemCompraDto>> IApplicationServiceOrdemCompra.ObterTodos()
        {
            var ordensCompra = serviceOrdemCompra.ObterTodos();
            return await Task.FromResult( mapperOrdemCompra.MapperListOrdensCompraDto(ordensCompra)).ConfigureAwait(false);
        }
    }
}