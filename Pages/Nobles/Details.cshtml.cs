using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dunca_Raul_Adrian_IE_ID_Proiect.Data;
using Dunca_Raul_Adrian_IE_ID_Proiect.Models;

namespace Dunca_Raul_Adrian_IE_ID_Proiect.Pages.Nobles
{
    public class DetailsModel : PageModel
    {
        private readonly Dunca_Raul_Adrian_IE_ID_Proiect.Data.Dunca_Raul_Adrian_IE_ID_ProiectContext _context;

        public DetailsModel(Dunca_Raul_Adrian_IE_ID_Proiect.Data.Dunca_Raul_Adrian_IE_ID_ProiectContext context)
        {
            _context = context;
        }

      public Noble Noble { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Noble == null)
            {
                return NotFound();
            }

            var noble = await _context.Noble.FirstOrDefaultAsync(m => m.ID == id);
            if (noble == null)
            {
                return NotFound();
            }
            else 
            {
                Noble = noble;
            }
            return Page();
        }
    }
}
