namespace DojoDDD.Application.Dtos
{
    public class ProdutoDto
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public decimal Estoque { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal ValorMinimoDeCompra { get; set; }
    }
}