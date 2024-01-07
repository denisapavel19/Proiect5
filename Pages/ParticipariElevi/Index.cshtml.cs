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
    public class IndexModel : PageModel
    {
        private readonly Proiect5.Data.Proiect5Context _context;

        public IndexModel(Proiect5.Data.Proiect5Context context)
        {
            _context = context;
        }

        public IList<ParticipareElev> ParticipareElev { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.ParticipareElev != null)
            {
                ParticipareElev = await _context.ParticipareElev
                .Include(p => p.elev)
                .Include(p => p.sedintameditatie).ToListAsync();
            }
        }
    }
}
