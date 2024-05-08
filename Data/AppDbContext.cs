using GerenciamentoIgrega.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoIgrega.Data;

public class AppDbContext : DbContext 
{
    public DbSet<Person> People { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Department> Departments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    => optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
    
}