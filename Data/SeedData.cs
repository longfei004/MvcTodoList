using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcTodoList.Models;
using MvcTodoList.Data;

namespace MvcTodoList.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcTodoListContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcTodoListContext>>()))
            {
                if(context.Todos.Any())
                {
                    return;
                }

                context.Todos.AddRange(
                  new Todo
                  {
                      Content = "Learning C#",
                      ExpectFinishedDate = DateTime.Parse("2019-12-25"),
                      IsDone = false
                  }
                );

                context.SaveChanges();
            }
        }
    }
}