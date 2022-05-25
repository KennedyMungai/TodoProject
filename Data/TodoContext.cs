using Microsoft.EntityFrameworkCore;

namespace TodoProject.Data;

public class TodoContext : DbContext
{
    public DbSet<Todo>? todo { get; set; }
    
    public TodoContext(DbContextOptions<TodoContext> options) : base(options)
    {
        
    }
}