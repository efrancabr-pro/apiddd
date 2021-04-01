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
    public class ClienteController : Controller
    {
        private readonly IApplicationServiceCliente _applicationServiceCliente;

        public ClienteController(IApplicationServiceCliente applicationServiceCliente)
        {
            _applicationServiceCliente = applicationServiceCliente;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            try
            {
                var clientes = await _applicationServiceCliente.ObterTodos();
                if (clientes == null)
                    return NoContent();

                return Ok(clientes);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get([FromRoute] int id)
        {
            try
            {
                var cliente = await _applicationServiceCliente.ObterPorId(id);
                if (cliente == null)
                    return NoContent();

                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex });
            }
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceCliente.Incluir(clienteDto);
                return Ok("Cliente incluído com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex });
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceCliente.Alterar(clienteDto);
                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex });
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceCliente.Excluir(clienteDto);
                return Ok("Cliente Excluído com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex });
            }
        }
    }
}