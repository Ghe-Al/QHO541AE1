using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Full_stack_application.model
{
    public class ToDoInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
