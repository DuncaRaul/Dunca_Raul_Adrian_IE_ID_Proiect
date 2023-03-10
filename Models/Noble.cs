using System.ComponentModel.DataAnnotations;

namespace Dunca_Raul_Adrian_IE_ID_Proiect.Models
{
    public class Noble
    {
        public int ID { get; set; }
        [Required, StringLength(150, MinimumLength = 3)]
        public String Name { get; set; }
        public String Rank { get; set; }
        [Range(12, 110)]
        public int Age { get; set; }
        public int TerritoryID { get; set; }
        public Territory? Territory { get; set; }
        public ICollection<Subject>? Subjects { get; set; }
        public ICollection<Army>? Armies { get; set; }
    }
}
