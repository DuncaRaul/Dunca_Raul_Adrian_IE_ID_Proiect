using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dunca_Raul_Adrian_IE_ID_Proiect.Data;
using Dunca_Raul_Adrian_IE_ID_Proiect.Models;

namespace Dunca_Raul_Adrian_IE_ID_Proiect.Pages.Territories
{
    public class DetailsModel : PageModel
    {
        private readonly Dunca_Raul_Adrian_IE_ID_Proiect.Data.Dunca_Raul_Adrian_IE_ID_ProiectContext _context;

        public DetailsModel(Dunca_Raul_Adrian_IE_ID_Proiect.Data.Dunca_Raul_Adrian_IE_ID_ProiectContext context)
        {
            _context = context;
        }

      public Territory Territory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Territory == null)
            {
                return NotFound();
            }

            var territory = await _context.Territory.FirstOrDefaultAsync(m => m.ID == id);
            if (territory == null)
            {
                return NotFound();
            }
            else 
            {
                Territory = territory;
            }
            return Page();
        }
    }
}
