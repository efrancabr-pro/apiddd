using DojoDDD.Application.Dtos;
using DojoDDD.Domain.Entitys;
using System.Collections.Generic;

namespace DojoDDD.Application.Interfaces.Mappers
{
    public interface IMapperOrdemCompra
    {
        OrdemCompra MapperDtoToEntity(OrdemCompraDto ordemCompraDto);

        IEnumerable<OrdemCompraDto> MapperListOrdensCompraDto(IEnumerable<OrdemCompra> ordensCompra);

        OrdemCompraDto MapperEntityToDto(OrdemCompra ordemCompra);
    }
}