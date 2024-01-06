using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect5.Data;
using Proiect5.Models;

namespace Proiect5.Pages.MateriiProfesori
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect5.Data.Proiect5Context _context;

        public DeleteModel(Proiect5.Data.Proiect5Context context)
        {
            _context = context;
        }

        [BindProperty]
      public MaterieProfesor MaterieProfesor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.MaterieProfesor == null)
            {
                return NotFound();
            }

            var materieprofesor = await _context.MaterieProfesor.FirstOrDefaultAsync(m => m.id == id);

            if (materieprofesor == null)
            {
                return NotFound();
            }
            else 
            {
                MaterieProfesor = materieprofesor;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.MaterieProfesor == null)
            {
                return NotFound();
            }
            var materieprofesor = await _context.MaterieProfesor.FindAsync(id);

            if (materieprofesor != null)
            {
                MaterieProfesor = materieprofesor;
                _context.MaterieProfesor.Remove(MaterieProfesor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
