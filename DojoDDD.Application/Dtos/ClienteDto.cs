namespace DojoDDD.Application.Dtos
{
    public class ClienteDto
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public short Idade { get; set; }
        public decimal Saldo { get; set; }
    }
}