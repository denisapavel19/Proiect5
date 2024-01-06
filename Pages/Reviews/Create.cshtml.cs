using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect5.Data;
using Proiect5.Models;

namespace Proiect5.Pages.Reviews
{
    public class CreateModel : PageModel
    {
        private readonly Proiect5.Data.Proiect5Context _context;

        public CreateModel(Proiect5.Data.Proiect5Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["parinteid"] = new SelectList(_context.Parinte, "id", "nume");
        ViewData["profesorid"] = new SelectList(_context.Profesor, "id", "nume");
            return Page();
        }

        [BindProperty]
        public Review Review { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Review == null || Review == null)
            {
                return Page();
            }

            _context.Review.Add(Review);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
