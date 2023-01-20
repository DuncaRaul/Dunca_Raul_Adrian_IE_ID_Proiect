using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dunca_Raul_Adrian_IE_ID_Proiect.Data;
using Dunca_Raul_Adrian_IE_ID_Proiect.Models;

namespace Dunca_Raul_Adrian_IE_ID_Proiect.Pages.Rulers
{
    public class DeleteModel : PageModel
    {
        private readonly Dunca_Raul_Adrian_IE_ID_Proiect.Data.Dunca_Raul_Adrian_IE_ID_ProiectContext _context;

        public DeleteModel(Dunca_Raul_Adrian_IE_ID_Proiect.Data.Dunca_Raul_Adrian_IE_ID_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Ruler Rulers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Rulers == null)
            {
                return NotFound();
            }

            var rulers = await _context.Rulers.FirstOrDefaultAsync(m => m.id == id);

            if (rulers == null)
            {
                return NotFound();
            }
            else 
            {
                Rulers = rulers;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Rulers == null)
            {
                return NotFound();
            }
            var rulers = await _context.Rulers.FindAsync(id);

            if (rulers != null)
            {
                Rulers = rulers;
                _context.Rulers.Remove(Rulers);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
