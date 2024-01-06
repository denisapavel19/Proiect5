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

namespace Proiect5.Pages.ProfesoriMaterii
{
    public class EditModel : PageModel
    {
        private readonly Proiect5.Data.Proiect5Context _context;

        public EditModel(Proiect5.Data.Proiect5Context context)
        {
            _context = context;
        }

        [BindProperty]
        public ProfesorMaterie ProfesorMaterie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ProfesorMaterie == null)
            {
                return NotFound();
            }

            var profesormaterie =  await _context.ProfesorMaterie.FirstOrDefaultAsync(m => m.id == id);
            if (profesormaterie == null)
            {
                return NotFound();
            }
            ProfesorMaterie = profesormaterie;
           ViewData["materieid"] = new SelectList(_context.Materie, "id", "id");
           ViewData["profesorid"] = new SelectList(_context.Profesor, "id", "id");
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

            _context.Attach(ProfesorMaterie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfesorMaterieExists(ProfesorMaterie.id))
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

        private bool ProfesorMaterieExists(int id)
        {
          return (_context.ProfesorMaterie?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
