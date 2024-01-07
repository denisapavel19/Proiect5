using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect5.Data;
using Proiect5.Models;

namespace Proiect5.Pages.ParticipariElevi
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
        ViewData["elevid"] = new SelectList(_context.Elev, "id", "nume");
        ViewData["sedintameditatieid"] = new SelectList(_context.SedintaMeditatie, "id", "inceput");
            return Page();
        }

        [BindProperty]
        public ParticipareElev ParticipareElev { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.ParticipareElev == null || ParticipareElev == null)
            {
                return Page();
            }

            _context.ParticipareElev.Add(ParticipareElev);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
