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
    public class DetailsModel : PageModel
    {
        private readonly Proiect5.Data.Proiect5Context _context;

        public DetailsModel(Proiect5.Data.Proiect5Context context)
        {
            _context = context;
        }

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
    }
}
