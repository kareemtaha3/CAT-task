

using Microsoft.EntityFrameworkCore;
using TodoListApi.Model;

public class TodoListContext : DbContext
{
    public TodoListContext()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public TodoListContext(DbContextOptions<TodoListContext> options) : base(options)
    {

    }
    public DbSet<Todo> Todos { get; set; }
}
