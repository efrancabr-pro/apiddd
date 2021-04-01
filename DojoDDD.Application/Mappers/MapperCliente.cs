using DojoDDD.Application.Dtos;
using DojoDDD.Application.Interfaces.Mappers;
using DojoDDD.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace DojoDDD.Application.Mappers
{
    public class MapperCliente : IMapperCliente
    {
        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                Id = clienteDto.Id,
                Nome = clienteDto.Nome,
                Endereco = clienteDto.Endereco,
                Idade = clienteDto.Idade,
                Saldo = clienteDto.Saldo,
            };

            return cliente;
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            var clienteDto = new ClienteDto()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Endereco = cliente.Endereco,
                Idade = cliente.Idade,
                Saldo = cliente.Saldo,
            };

            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(x => new ClienteDto
            {
                Id = x.Id,
                Nome = x.Nome,
                Endereco = x.Endereco,
                Idade = x.Idade,
                Saldo = x.Saldo
            });

            return dto;
        }
    }
}