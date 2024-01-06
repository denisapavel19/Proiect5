using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect5.Data;
using Proiect5.Models;

namespace Proiect5.Pages.MateriiProfesori
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
        ViewData["materieid"] = new SelectList(_context.Materie, "id", "denumire");
        ViewData["profesorid"] = new SelectList(_context.Profesor, "id", "nume");
            return Page();
        }

        [BindProperty]
        public MaterieProfesor MaterieProfesor { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.MaterieProfesor == null || MaterieProfesor == null)
            {
                return Page();
            }

            _context.MaterieProfesor.Add(MaterieProfesor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
