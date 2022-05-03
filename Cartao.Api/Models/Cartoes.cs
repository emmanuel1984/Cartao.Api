namespace Cartao.Api.Models
{
    public class Cartoes
    {
        public int Id { get; set; }
        public string TipoCartao { get; set; }
        public string NumeroCartao { get; set; }
        public bool StatusCartao { get; set; }
        public int IdPessoa { get; set; }
    }
}
