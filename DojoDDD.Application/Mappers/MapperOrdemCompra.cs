using DojoDDD.Application.Dtos;
using DojoDDD.Application.Interfaces.Mappers;
using DojoDDD.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace DojoDDD.Application.Mappers
{
    public class MapperOrdemCompra : IMapperOrdemCompra
    {
        public OrdemCompra MapperDtoToEntity(OrdemCompraDto ordemCompraDto)
        {
            var ordemCompra = new OrdemCompra
            {
                Id = ordemCompraDto.Id,
                ClienteId = ordemCompraDto.ClienteId,
                ProdutoId = ordemCompraDto.ProdutoId,
                PrecoUnitario = ordemCompraDto.PrecoUnitario,
                QuantidadeSolicitada = ordemCompraDto.QuantidadeSolicitada,
                ValorOperacao = ordemCompraDto.ValorOperacao,
                DataOperacao = ordemCompraDto.DataOperacao
            };

            return ordemCompra;
        }

        public OrdemCompraDto MapperEntityToDto(OrdemCompra ordemCompra)
        {
            var ordemCompraDto = new OrdemCompraDto
            {
                Id = ordemCompra.Id,
                ClienteId = ordemCompra.ClienteId,
                ProdutoId = ordemCompra.ProdutoId,
                PrecoUnitario = ordemCompra.PrecoUnitario,
                QuantidadeSolicitada = ordemCompra.QuantidadeSolicitada,
                ValorOperacao = ordemCompra.ValorOperacao,
                DataOperacao = ordemCompra.DataOperacao
            };

            return ordemCompraDto;
        }

        public IEnumerable<OrdemCompraDto> MapperListOrdensCompraDto(IEnumerable<OrdemCompra> ordensCompra)
        {
            var dto = ordensCompra.Select(x => new OrdemCompraDto
            {
                Id = x.Id,
                ClienteId = x.ClienteId,
                ProdutoId = x.ProdutoId,
                PrecoUnitario = x.PrecoUnitario,
                QuantidadeSolicitada = x.QuantidadeSolicitada,
                ValorOperacao = x.ValorOperacao,
                DataOperacao = x.DataOperacao
            });

            return dto;
        }
    }
}