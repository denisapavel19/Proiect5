using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect5.Data;
using Proiect5.Models;

namespace Proiect5.Pages.Materii
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect5.Data.Proiect5Context _context;

        public DetailsModel(Proiect5.Data.Proiect5Context context)
        {
            _context = context;
        }

      public Materie Materie { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Materie == null)
            {
                return NotFound();
            }

            var materie = await _context.Materie.FirstOrDefaultAsync(m => m.id == id);
            if (materie == null)
            {
                return NotFound();
            }
            else 
            {
                Materie = materie;
            }
            return Page();
        }
    }
}
