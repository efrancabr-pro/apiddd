using DojoDDD.Application.Dtos;
using DojoDDD.Application.Interfaces;
using DojoDDD.Application.Interfaces.Mappers;
using DojoDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto serviceProduto;
        private readonly IMapperProduto mapperProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto
                                        , IMapperProduto mapperProduto)
        {
            this.serviceProduto = serviceProduto;
            this.mapperProduto = mapperProduto;
        }

        public void Alterar(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Alterar(produto);
        }

        public void Excluir(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Excluir(produto);
        }

        public void Incluir(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Incluir(produto);
        }

        public ProdutoDto ObterPorId(int id)
        {
            var produto = serviceProduto.ObterPorId(id);
            return mapperProduto.MapperEntityToDto(produto);
        }

        public IEnumerable<ProdutoDto> ObterTodos()
        {
            var produtos = serviceProduto.ObterTodos();
            return mapperProduto.MapperListProdutosDto(produtos);
        }

        async Task<ProdutoDto> IApplicationServiceProduto.ObterPorId(int id)
        {
            var produto = serviceProduto.ObterPorId(id);
            return  await Task.FromResult(mapperProduto.MapperEntityToDto(produto)).ConfigureAwait(false);
        }

        async Task<IEnumerable<ProdutoDto>> IApplicationServiceProduto.ObterTodos()
        {
            var produtos = serviceProduto.ObterTodos();
            return await Task.FromResult(mapperProduto.MapperListProdutosDto(produtos)).ConfigureAwait(false);
        }
    }
}