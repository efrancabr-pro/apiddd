namespace DojoDDD.Domain.Entitys
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public short Idade { get; set; }
        public decimal Saldo { get; set; }
    }
}
