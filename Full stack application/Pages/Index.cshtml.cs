using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Full_stack_application.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Full_stack_application.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)

        {
            _db = db;
        }

        public IEnumerable<ToDoInfo> info { get; set; }
        public async Task OnGet()
        {
            info = await _db.tblTodo.ToListAsync();

        }
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var book = await _db.tblTodo.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            _db.tblTodo.Remove(book);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}