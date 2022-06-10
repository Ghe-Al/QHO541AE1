using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Full_stack_application.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Full_stack_application.Pages.booklist
{
    public class createModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public createModel(ApplicationDbContext db)

        {
            _db = db;
        }

        [BindProperty]
        public ToDoInfo info { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.tblTodo.AddAsync(info);
                await _db.SaveChangesAsync();
                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }

        }
    }
}

