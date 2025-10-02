using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Employee> Employees { get; set; }   // 👈 thêm dòng này
    }
}
