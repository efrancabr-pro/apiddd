using DojoDDD.Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Incluir(ClienteDto clienteDto);

        void Alterar(ClienteDto clienteDto);

        void Excluir(ClienteDto clienteDto);

        Task<ClienteDto> ObterPorId(int id);

        Task<IEnumerable<ClienteDto>> ObterTodos();
    }
}