using Microsoft.EntityFrameworkCore;

namespace ProblemsApi.Data
{
    public class ProblemsDbContext : DbContext
    {
        public ProblemsDbContext(DbContextOptions<ProblemsDbContext> option) : base(option) { }
    }
}