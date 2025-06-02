using Aula.Model;
using Microsoft.EntityFrameworkCore;

namespace Aula.Data
{
    internal class DataContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLSERVER2014ECE; Initial Catalog=DBBiblioteca; Integrated Security=SSPI; TrustServerCertificate=true");
        }
    }
}
