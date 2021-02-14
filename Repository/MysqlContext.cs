using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore;
using TodoApi.Domain.Model;

namespace TodoApi.Repository {
    public class MysqlContext : DbContext 
    {
        public DbSet<Todo> Todos{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
         => optionsBuilder.UseMySQL(@"server=localhost;database=testdb;userid=root;password=root;sslmode=none;");
    }
}