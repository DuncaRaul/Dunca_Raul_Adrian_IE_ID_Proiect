using System.ComponentModel.DataAnnotations;

namespace Dunca_Raul_Adrian_IE_ID_Proiect.Models
{
    public class Subject
    {
        public int ID { get; set; }
        [Required, StringLength(150, MinimumLength = 3)]
        public String Name { get; set; }
        public String Status { get; set; }
        [Range(12, 110)]
        public int Age { get; set; }
        public int NobleID { get; set; }
        public Noble? Noble { get; set; }
        public int? ArmyID { get; set; }
        public Army? Army { get;set; }
    }
}
