using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect5.Data;
using Proiect5.Models;

namespace Proiect5.Pages.ParticipariElevi
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect5.Data.Proiect5Context _context;

        public DeleteModel(Proiect5.Data.Proiect5Context context)
        {
            _context = context;
        }

        [BindProperty]
      public ParticipareElev ParticipareElev { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ParticipareElev == null)
            {
                return NotFound();
            }

            var participareelev = await _context.ParticipareElev.FirstOrDefaultAsync(m => m.id == id);

            if (participareelev == null)
            {
                return NotFound();
            }
            else 
            {
                ParticipareElev = participareelev;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.ParticipareElev == null)
            {
                return NotFound();
            }
            var participareelev = await _context.ParticipareElev.FindAsync(id);

            if (participareelev != null)
            {
                ParticipareElev = participareelev;
                _context.ParticipareElev.Remove(ParticipareElev);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
