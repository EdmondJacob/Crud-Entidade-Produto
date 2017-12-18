using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CrudProduto.Models
{
    public class ProdutoContexto : DbContext
    {
        public ProdutoContexto() : base("ProdutoContexto")
        {

        }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
