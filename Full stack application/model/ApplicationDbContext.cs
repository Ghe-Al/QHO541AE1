using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Full_stack_application.model
{
    public class ApplicationDbContext : DbContext
    {
        //inherit entity framework classes, use classes of entity framework in constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<ToDoInfo> tblTodo { get; set; }
    }
}