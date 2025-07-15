using CadastroFuncionariosAzure.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroFuncionariosAzure.Context
{
    public class RHContext: DbContext
    {
        public RHContext(DbContextOptions<RHContext> options) : base(options)
        {

        }

        public DbSet<Funcionario> Funcionarios { get; set; }

    }
}
