using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect5.Data;
using Proiect5.Models;

namespace Proiect5.Pages.EleviMaterii
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect5.Data.Proiect5Context _context;

        public DeleteModel(Proiect5.Data.Proiect5Context context)
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

            var elevmaterie = await _context.ElevMaterie.FirstOrDefaultAsync(m => m.id == id);

            if (elevmaterie == null)
            {
                return NotFound();
            }
            else 
            {
                ElevMaterie = elevmaterie;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.ElevMaterie == null)
            {
                return NotFound();
            }
            var elevmaterie = await _context.ElevMaterie.FindAsync(id);

            if (elevmaterie != null)
            {
                ElevMaterie = elevmaterie;
                _context.ElevMaterie.Remove(ElevMaterie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
