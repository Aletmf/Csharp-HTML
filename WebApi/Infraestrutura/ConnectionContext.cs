using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.Infraestrutura
{
    public class ConnectionContext : DbContext // Herdar para fazer conexão no banco
    {
        public DbSet<Employee> Employees { get; set; }

        // Aqui sobrescreveremos o método OnConfiguring do DbContext, para informar os dados da conexão com nosso banco!
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql
            (
                "Server= localhost;" +
                "Port=5432;Database=employee_sample;" +
                "User Id=postgres;" +
                "Password=alessandro1408;"
            );
            
                
            

    }
}
