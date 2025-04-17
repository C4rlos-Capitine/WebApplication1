using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WebApplication1
{
    public class MeuDbContextFactory : IDesignTimeDbContextFactory<MeuDbContext>
    {
        public MeuDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MeuDbContext>();
            optionsBuilder.UseSqlServer("Data Source=FALCAO\\SQLEXPRESS16;Initial Catalog=WEBAPP;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False;");

            return new MeuDbContext(optionsBuilder.Options);
        }
    }
}
