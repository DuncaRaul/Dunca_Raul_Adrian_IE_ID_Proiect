using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dunca_Raul_Adrian_IE_ID_Proiect.Data;
using Dunca_Raul_Adrian_IE_ID_Proiect.Models;

namespace Dunca_Raul_Adrian_IE_ID_Proiect.Pages.Armies
{
    public class DeleteModel : PageModel
    {
        private readonly Dunca_Raul_Adrian_IE_ID_Proiect.Data.Dunca_Raul_Adrian_IE_ID_ProiectContext _context;

        public DeleteModel(Dunca_Raul_Adrian_IE_ID_Proiect.Data.Dunca_Raul_Adrian_IE_ID_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Army Army { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Army == null)
            {
                return NotFound();
            }

            var army = await _context.Army.FirstOrDefaultAsync(m => m.ID == id);

            if (army == null)
            {
                return NotFound();
            }
            else 
            {
                Army = army;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Army == null)
            {
                return NotFound();
            }
            var army = await _context.Army.FindAsync(id);

            if (army != null)
            {
                Army = army;
                _context.Army.Remove(Army);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
