using System.ComponentModel.DataAnnotations;

namespace Dunca_Raul_Adrian_IE_ID_Proiect.Models
{
    public class Army
    {
        public int ID { get; set; }
        [Required, StringLength(150, MinimumLength = 3)]
        public String Type { get; set; }
        public int Size { get; set; }
        public int NobleID { get; set; }
        public Noble? Noble { get; set; }
        public ICollection<Subject>? Subjects { get; set; }
    }
}
