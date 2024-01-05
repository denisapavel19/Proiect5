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

namespace Proiect5.Pages.Parinti
{
    public class EditModel : PageModel
    {
        private readonly Proiect5.Data.Proiect5Context _context;

        public EditModel(Proiect5.Data.Proiect5Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Parinte Parinte { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Parinte == null)
            {
                return NotFound();
            }

            var parinte =  await _context.Parinte.FirstOrDefaultAsync(m => m.id == id);
            if (parinte == null)
            {
                return NotFound();
            }
            Parinte = parinte;
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

            _context.Attach(Parinte).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParinteExists(Parinte.id))
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

        private bool ParinteExists(int id)
        {
          return (_context.Parinte?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
