using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Full_stack_application.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Full_stack_application.Pages.booklist
{
    public class editModel : PageModel
    {
        
            private readonly ApplicationDbContext _db;
            public editModel(ApplicationDbContext db)

            {
                _db = db;
            }

            [BindProperty]
            public ToDoInfo info { get; set; }

            public async Task OnGet(int id)
            {
                info = await _db.tblTodo.FindAsync(id);
            }
            public async Task<IActionResult> OnPost()
            {
                if (ModelState.IsValid)
                {
                    var bookFromDb = await _db.tblTodo.FindAsync(info.Id);
                    bookFromDb.Content = info.Content;

                    await _db.SaveChangesAsync();
                    return RedirectToPage("/Index");
                }
                return RedirectToPage();
            }
    }
}

