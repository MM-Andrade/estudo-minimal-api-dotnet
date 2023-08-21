using Microsoft.EntityFrameworkCore;
using TodoAPI.Model;

namespace TodoAPI.Data
{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options) : base(options)
        {            
        }

        public DbSet<Todo> Todos => Set<Todo>();
    }


}
