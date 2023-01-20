namespace Dunca_Raul_Adrian_IE_ID_Proiect.Models
{
    public class Noble
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Rank { get; set; }
        public int Age { get; set; }
        public int TerritoryID { get; set; }
        public Territory? Territory { get; set; }
    }
}
