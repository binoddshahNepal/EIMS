using Microsoft.EntityFrameworkCore;

namespace EIMS.Models
{
    public class employeeContext:DbContext
    {
        public employeeContext(DbContextOptions<employeeContext> options):base(options)
        {
                
        }
        public DbSet<users> users { get; set; }
    }
}
