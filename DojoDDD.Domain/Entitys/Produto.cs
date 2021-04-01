namespace DojoDDD.Domain.Entitys
{
    public class Produto : Base
    {
        public string Descricao { get; set; }
        public decimal Estoque { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal ValorMinimoDeCompra { get; set; }
    }
}
