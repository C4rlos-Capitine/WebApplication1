namespace WebApplication1.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? email { get; set; }
        public string? telefone { get; set; }
        public string? celular { get; set; }
        public string? endereco { get; set; }
        public string? nuit { get; set; }

        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}