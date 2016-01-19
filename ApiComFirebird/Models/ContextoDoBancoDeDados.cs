using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ApiComFirebird.Models
{
    /// <summary>
    /// Classe que � usada para se comunicar com o banco de dados, DbContext � uma classe do Entity Framework que � o ORM
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