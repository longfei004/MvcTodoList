using System;
using System.ComponentModel.DataAnnotations;

namespace MvcTodoList.Models
{
    public class Todo
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Content { get; set; }

        [Display (Name = "Expect Finished Date")]
        [DataType (DataType.Date)]
        public DateTime ExpectFinishedDate { get; set; }

        public bool IsDone { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string AssignTo { get; set; }
    }
}