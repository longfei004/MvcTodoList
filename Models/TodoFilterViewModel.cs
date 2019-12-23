using System.Collections.Generic;

namespace MvcTodoList.Models
{
    public class TodoFilterViewModel
    {
        public List<Todo> Todos { get; set; }
        public string IsDone { get; set; }
        public string SearchString { get; set; }
    }
}