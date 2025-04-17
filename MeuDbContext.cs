using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

public class MeuDbContext : DbContext
{
    public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options) { }

    // Adicionando o DbSet da entidade Produto
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Fornecedor> Fornecedores { get; set; }
}
