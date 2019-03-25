using System;
using System.Data.Entity;

namespace Infra.Data.Models
{
    public class BancoDadosContext : DbContext, IDisposable
    {
        //Sempre o nome do modelo de negocio ou banco de negocios + context.
        
        private static string StringConexao = "Data Source=localhost;Initial Catalog=LojaDB;Integrated Security=True;Pooling=False";

        static BancoDadosContext()
        {
            Database.SetInitializer<BancoDadosContext>(null);
        }

        public BancoDadosContext() : base(StringConexao)
        {

        }

        public DbSet<Devedores> Devedores { get; set; } // Aqui são cada tabela que será definida no banco de dados.

        public DbSet<Produto> Produtos { get; set; } // Aqui são cada tabela que será definida no banco de dados.

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("LOJA_DB");
            modelBuilder.Entity<Produto>().ToTable("Produtos", "dbo");
            modelBuilder.Entity<Devedores>().ToTable("Cad_devf", "dbo");
        }
    }
}