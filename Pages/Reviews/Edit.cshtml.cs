using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect5.Data;
using Proiect5.Models;

namespace Proiect5.Pages.Reviews
{
    public class EditModel : PageModel
    {
        private readonly Proiect5.Data.Proiect5Context _context;

        public EditModel(Proiect5.Data.Proiect5Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Review Review { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Review == null)
            {
                return NotFound();
            }

            var review =  await _context.Review.FirstOrDefaultAsync(m => m.id == id);
            if (review == null)
            {
                return NotFound();
            }
            Review = review;
           ViewData["parinteid"] = new SelectList(_context.Parinte, "id", "nume");
           ViewData["profesorid"] = new SelectList(_context.Profesor, "id", "nume");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Review).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReviewExists(Review.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ReviewExists(int id)
        {
          return (_context.Review?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
