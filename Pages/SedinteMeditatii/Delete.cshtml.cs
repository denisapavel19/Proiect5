using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect5.Data;
using Proiect5.Models;

namespace Proiect5.Pages.SedinteMeditatii
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect5.Data.Proiect5Context _context;

        public DeleteModel(Proiect5.Data.Proiect5Context context)
        {
            _context = context;
        }

        [BindProperty]
      public SedintaMeditatie SedintaMeditatie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.SedintaMeditatie == null)
            {
                return NotFound();
            }

            var sedintameditatie = await _context.SedintaMeditatie.FirstOrDefaultAsync(m => m.id == id);

            if (sedintameditatie == null)
            {
                return NotFound();
            }
            else 
            {
                SedintaMeditatie = sedintameditatie;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.SedintaMeditatie == null)
            {
                return NotFound();
            }
            var sedintameditatie = await _context.SedintaMeditatie.FindAsync(id);

            if (sedintameditatie != null)
            {
                SedintaMeditatie = sedintameditatie;
                _context.SedintaMeditatie.Remove(SedintaMeditatie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
