using DojoDDD.Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Application.Interfaces
{
    public interface IApplicationServiceOrdemCompra
    {
        void Incluir(OrdemCompraDto ordemCompraDto);

        void Alterar(OrdemCompraDto ordemCompraDto);

        void Excluir(OrdemCompraDto ordemCompraDto);

        Task<OrdemCompraDto> ObterPorId(string id);

        Task<IEnumerable<OrdemCompraDto>> ObterTodos();
    }
}