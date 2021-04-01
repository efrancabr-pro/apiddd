using DojoDDD.Domain.Enums;
using System;

namespace DojoDDD.Domain.Entitys
{
    public class OrdemCompra : Base
    {
        public OrdemCompra()
        {
            Status = OrdemCompraStatus.Solicitado;
        }

        new public string Id { get; set; } = Guid.NewGuid().ToString();

        public DateTime DataOperacao { get; set; }
        public long ProdutoId { get; set; }
        public long ClienteId { get; set; }
        public double QuantidadeSolicitada { get; set; }
        public decimal ValorOperacao { get; set; }
        public decimal PrecoUnitario { get; set; }
        public OrdemCompraStatus Status { get; set; }

    }
}
