using DojoDDD.Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Incluir(ProdutoDto produtoDto);

        void Alterar(ProdutoDto produtoDto);

        void Excluir(ProdutoDto produtoDto);

        Task<ProdutoDto> ObterPorId(int id);

        Task<IEnumerable<ProdutoDto>> ObterTodos();
    }
}