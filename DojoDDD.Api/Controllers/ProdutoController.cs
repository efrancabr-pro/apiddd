using DojoDDD.Application.Dtos;
using DojoDDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IApplicationServiceProduto _applicationServiceProduto;

        public ProdutoController(IApplicationServiceProduto applicationServiceProduto)
        {
            _applicationServiceProduto = applicationServiceProduto;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            try
            {
                var produtos = await _applicationServiceProduto.ObterTodos();
                if (produtos == null)
                    return NoContent();

                return Ok(produtos);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(int id)
        {
            try
            {
                var produto = await _applicationServiceProduto.ObterPorId(id);
                if (produto == null)
                    return NoContent();

                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex });
            }
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _applicationServiceProduto.Incluir(produtoDto);
                return Ok("Produto Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex });
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _applicationServiceProduto.Alterar(produtoDto);
                return Ok("Produto Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex });
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _applicationServiceProduto.Excluir(produtoDto);
                return Ok("Produto excluído com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex });
            }
        }
    }
}