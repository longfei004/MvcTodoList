using Microsoft.EntityFrameworkCore;
using MvcTodoList.Models;

namespace MvcTodoList.Data
{
    public class MvcTodoListContext : DbContext
    {
        public MvcTodoListContext(DbContextOptions<MvcTodoListContext> options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }
}