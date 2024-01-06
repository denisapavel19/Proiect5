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

namespace Proiect5.Pages.EleviMaterii
{
    public class EditModel : PageModel
    {
        private readonly Proiect5.Data.Proiect5Context _context;

        public EditModel(Proiect5.Data.Proiect5Context context)
        {
            _context = context;
        }

        [BindProperty]
        public ElevMaterie ElevMaterie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ElevMaterie == null)
            {
                return NotFound();
            }

            var elevmaterie =  await _context.ElevMaterie.FirstOrDefaultAsync(m => m.id == id);
            if (elevmaterie == null)
            {
                return NotFound();
            }
            ElevMaterie = elevmaterie;
           ViewData["elevid"] = new SelectList(_context.Elev, "id", "nume");
           ViewData["materieid"] = new SelectList(_context.Materie, "id", "denumire");
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

            _context.Attach(ElevMaterie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElevMaterieExists(ElevMaterie.id))
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

        private bool ElevMaterieExists(int id)
        {
          return (_context.ElevMaterie?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
