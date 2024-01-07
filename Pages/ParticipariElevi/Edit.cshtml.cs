﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect5.Data;
using Proiect5.Models;

namespace Proiect5.Pages.ParticipariElevi
{
    public class EditModel : PageModel
    {
        private readonly Proiect5.Data.Proiect5Context _context;

        public EditModel(Proiect5.Data.Proiect5Context context)
        {
            _context = context;
        }

        [BindProperty]
        public ParticipareElev ParticipareElev { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ParticipareElev == null)
            {
                return NotFound();
            }

            var participareelev =  await _context.ParticipareElev.FirstOrDefaultAsync(m => m.id == id);
            if (participareelev == null)
            {
                return NotFound();
            }
            ParticipareElev = participareelev;
           ViewData["elevid"] = new SelectList(_context.Elev, "id", "id");
           ViewData["sedintameditatieid"] = new SelectList(_context.SedintaMeditatie, "id", "id");
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

            _context.Attach(ParticipareElev).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParticipareElevExists(ParticipareElev.id))
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

        private bool ParticipareElevExists(int id)
        {
          return (_context.ParticipareElev?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
