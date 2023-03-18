
using EIMS.Models;
using Microsoft.EntityFrameworkCore;  
  
namespace EIMS.AppContext;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }
}