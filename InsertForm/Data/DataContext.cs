using Microsoft.EntityFrameworkCore;

namespace InsertForm.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<UserForm> UserForm { get; set; }
    }
}
