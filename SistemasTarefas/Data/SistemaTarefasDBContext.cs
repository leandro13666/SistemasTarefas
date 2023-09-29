using Microsoft.EntityFrameworkCore;
using SistemasTarefas.Data.Map;
using SistemasTarefas.Models;

namespace SistemasTarefas.Data
{
    public class SistemaTarefasDBContext : DbContext
    {
        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext> options)
            : base(options) 
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }   
        public DbSet<TarefasModel> Tarefas { get; set; }
        public DbSet<ProdutoModel> Produto { get; set; }
        public DbSet<ClienteModel> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefasMap());
            

            base.OnModelCreating(modelBuilder);
        }
    }
}
