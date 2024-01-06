using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect5.Data;
using Proiect5.Models;

namespace Proiect5.Pages.ProfesoriMaterii
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect5.Data.Proiect5Context _context;

        public DeleteModel(Proiect5.Data.Proiect5Context context)
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

            var profesormaterie = await _context.ProfesorMaterie.FirstOrDefaultAsync(m => m.id == id);

            if (profesormaterie == null)
            {
                return NotFound();
            }
            else 
            {
                ProfesorMaterie = profesormaterie;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.ProfesorMaterie == null)
            {
                return NotFound();
            }
            var profesormaterie = await _context.ProfesorMaterie.FindAsync(id);

            if (profesormaterie != null)
            {
                ProfesorMaterie = profesormaterie;
                _context.ProfesorMaterie.Remove(ProfesorMaterie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
