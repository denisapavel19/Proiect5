using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect5.Data;
using Proiect5.Models;

namespace Proiect5.Pages.Parinti
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect5.Data.Proiect5Context _context;

        public DetailsModel(Proiect5.Data.Proiect5Context context)
        {
            _context = context;
        }

      public Parinte Parinte { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Parinte == null)
            {
                return NotFound();
            }

            var parinte = await _context.Parinte.FirstOrDefaultAsync(m => m.id == id);
            if (parinte == null)
            {
                return NotFound();
            }
            else 
            {
                Parinte = parinte;
            }
            return Page();
        }
    }
}
