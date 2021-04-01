using DojoDDD.Application.Dtos;
using DojoDDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Api.Controllers
{
    [Route("ordemcompra")]
    [ApiController]
    public class OrdemCompraController : Controller
    {
        private readonly IApplicationServiceOrdemCompra _applicationServiceOrdemCompra;

        public OrdemCompraController(IApplicationServiceOrdemCompra applicationServiceOrdemCompra)
        {
            _applicationServiceOrdemCompra = applicationServiceOrdemCompra;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            try
            {
                var ordensCompra = await _applicationServiceOrdemCompra.ObterTodos();
                if (ordensCompra == null)
                    return NoContent();

                return Ok(ordensCompra);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(string id)
        {
            try
            {
                var ordemCompra = await _applicationServiceOrdemCompra.ObterPorId(id);
                if (ordemCompra == null)
                    return NoContent();

                return Ok(ordemCompra);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex });
            }
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] OrdemCompraDto ordemCompraDto)
        {
            try
            {
                if (ordemCompraDto == null)
                    return NotFound();

                _applicationServiceOrdemCompra.Incluir(ordemCompraDto);
                return Ok("Ordem de Compra incluída com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex });
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] OrdemCompraDto ordemCompraDto)
        {
            try
            {
                if (ordemCompraDto == null)
                    return NotFound();

                _applicationServiceOrdemCompra.Alterar(ordemCompraDto);
                return Ok("Ordem de Compra Atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex });
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] OrdemCompraDto ordemCompraDto)
        {
            try
            {
                if (ordemCompraDto == null)
                    return NotFound();

                _applicationServiceOrdemCompra.Excluir(ordemCompraDto);
                return Ok("Ordem de Compra Excluída com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex });
            }
        }
    }
}