using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dunca_Raul_Adrian_IE_ID_Proiect.Data;
using Dunca_Raul_Adrian_IE_ID_Proiect.Models;
using System.Security.Policy;

namespace Dunca_Raul_Adrian_IE_ID_Proiect.Pages.Rulers
{
    public class EditModel : PageModel
    {
        private readonly Dunca_Raul_Adrian_IE_ID_Proiect.Data.Dunca_Raul_Adrian_IE_ID_ProiectContext _context;

        public EditModel(Dunca_Raul_Adrian_IE_ID_Proiect.Data.Dunca_Raul_Adrian_IE_ID_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Ruler Rulers { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Rulers == null)
            {
                return NotFound();
            }

            var rulers =  await _context.Rulers.FirstOrDefaultAsync(m => m.id == id);
            if (rulers == null)
            {
                return NotFound();
            }
            Rulers = rulers;
            ViewData["TerritoryID"] = new SelectList(_context.Set<Territory>(), "ID", "Name");
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

            _context.Attach(Rulers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RulersExists(Rulers.id))
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

        private bool RulersExists(int id)
        {
          return _context.Rulers.Any(e => e.id == id);
        }
    }
}
