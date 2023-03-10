using System.ComponentModel.DataAnnotations;

namespace Dunca_Raul_Adrian_IE_ID_Proiect.Models
{
    public class Territory
    {
        public int ID { get; set; }
        [Required, StringLength(150, MinimumLength = 3)]
        public String Name { get; set; }
        public String Type { get; set; }
        public int Size { get; set; }
        public Ruler? Ruler { get; set; }
        public ICollection<Noble>? Nobles { get; set; }
    }
}
