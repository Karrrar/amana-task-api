
using Microsoft.EntityFrameworkCore;
using Amana_Api.Model;

namespace Amana_Api
{
    public class TaskContext : DbContext
    {
        public DbSet<TaskItem> Task { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite("Data Source=tasks.db");
    }

}
