using System.ComponentModel.DataAnnotations;

namespace Dunca_Raul_Adrian_IE_ID_Proiect.Models
{
    public class Ruler
    {
        public int id { get; set; }
        [Display(Name = "Ruler Name")]
        public String name { get; set; }
        [Display(Name = "Public Acceptance")]
        public String publicAcceptance { get; set; }
        public int age { get; set; }
        public int TerritoryID { get; set; }
        public Territory? Territory { get; set; }
    }
}
