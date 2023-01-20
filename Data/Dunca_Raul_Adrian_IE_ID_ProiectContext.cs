using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dunca_Raul_Adrian_IE_ID_Proiect.Models;

namespace Dunca_Raul_Adrian_IE_ID_Proiect.Data
{
    public class Dunca_Raul_Adrian_IE_ID_ProiectContext : DbContext
    {
        public Dunca_Raul_Adrian_IE_ID_ProiectContext (DbContextOptions<Dunca_Raul_Adrian_IE_ID_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Dunca_Raul_Adrian_IE_ID_Proiect.Models.Ruler> Rulers { get; set; } = default!;

        public DbSet<Dunca_Raul_Adrian_IE_ID_Proiect.Models.Territory> Territory { get; set; }

        public DbSet<Dunca_Raul_Adrian_IE_ID_Proiect.Models.Noble> Noble { get; set; }
    }
}
