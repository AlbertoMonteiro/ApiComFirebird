using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ApiComFirebird.Models
{
    /// <summary>
    /// Classe que é usada para se comunicar com o banco de dados, DbContext é uma classe do Entity Framework que é o ORM
    /// </summary>
    public class ContextoDoBancoDeDados : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}