using DojoDDD.Domain.Enums;
using System;

namespace DojoDDD.Application.Dtos
{
    public class OrdemCompraDto
    {
        public string Id { get; set; }
        public DateTime DataOperacao { get; set; }
        public long ProdutoId { get; set; }
        public long ClienteId { get; set; }
        public double QuantidadeSolicitada { get; set; }
        public decimal ValorOperacao { get; set; }
        public decimal PrecoUnitario { get; set; }
        public OrdemCompraStatus Status { get; set; }
    }
}