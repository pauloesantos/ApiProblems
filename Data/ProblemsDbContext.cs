using ApiProblems.Models;
using Microsoft.EntityFrameworkCore;

namespace ProblemsApi.Data
{
    public class ProblemsDbContext : DbContext
    {
        public ProblemsDbContext(DbContextOptions<ProblemsDbContext> option) : base(option) { }
    }
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}