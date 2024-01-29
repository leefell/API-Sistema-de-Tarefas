using API_SistemaDeTarefas.Data.Map;
using API_SistemaDeTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace API_SistemaDeTarefas.Data
{
    public class SistemaDeTarefasDBContext : DbContext
    {
        public SistemaDeTarefasDBContext(DbContextOptions<SistemaDeTarefasDBContext> options) : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; } // tabela Usuarios
        public DbSet<TarefaModel> Tarefas { get; set; } // tabela tarefas

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //método chamado quando o modelo do banco de dados está sendo criado pela primeira vez
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
