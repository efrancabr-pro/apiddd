using DojoDDD.Application.Dtos;
using DojoDDD.Application.Interfaces.Mappers;
using DojoDDD.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace DojoDDD.Application.Mappers
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Id = produtoDto.Id,
                Descricao = produtoDto.Descricao,
                Estoque = produtoDto.Estoque,
                PrecoUnitario = produtoDto.PrecoUnitario,
                ValorMinimoDeCompra = produtoDto.ValorMinimoDeCompra
            };

            return produto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produto.Id,
                Descricao = produto.Descricao,
                Estoque = produto.Estoque,
                PrecoUnitario = produto.PrecoUnitario,
                ValorMinimoDeCompra = produto.ValorMinimoDeCompra
            };

            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(x => new ProdutoDto
            {
                Id = x.Id,
                Descricao = x.Descricao,
                Estoque = x.Estoque,
                PrecoUnitario = x.PrecoUnitario,
                ValorMinimoDeCompra = x.ValorMinimoDeCompra
            });

            return dto;
        }
    }
}