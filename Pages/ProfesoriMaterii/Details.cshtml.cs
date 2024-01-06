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
    public class DetailsModel : PageModel
    {
        private readonly Proiect5.Data.Proiect5Context _context;

        public DetailsModel(Proiect5.Data.Proiect5Context context)
        {
            _context = context;
        }

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
    }
}
