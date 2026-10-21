using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class TaskManagerContext:DbContext
    {
        private readonly IConfiguration? _configuration;
        public TaskManagerContext(IConfiguration? configuration = null)
        {
            _configuration = configuration;
        }

        public DbSet<TaskItem> TaskItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string? connectionString = _configuration?.GetConnectionString("TaskManagerContext");

                if (string.IsNullOrEmpty(connectionString))
                    throw new InvalidOperationException("Connection string 'TaskManagerContext' not found. Check User Secrets.");

                optionsBuilder.UseMySql(connectionString, ServerVersion.Parse("8.0.33-mysql"),
                    options => options.CommandTimeout(180));
            }
        }
    }
}
