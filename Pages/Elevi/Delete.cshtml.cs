using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect5.Data;
using Proiect5.Models;

namespace Proiect5.Pages.Elevi
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect5.Data.Proiect5Context _context;

        public DeleteModel(Proiect5.Data.Proiect5Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Elev Elev { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Elev == null)
            {
                return NotFound();
            }

            var elev = await _context.Elev.FirstOrDefaultAsync(m => m.id == id);

            if (elev == null)
            {
                return NotFound();
            }
            else 
            {
                Elev = elev;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Elev == null)
            {
                return NotFound();
            }
            var elev = await _context.Elev.FindAsync(id);

            if (elev != null)
            {
                Elev = elev;
                _context.Elev.Remove(Elev);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
