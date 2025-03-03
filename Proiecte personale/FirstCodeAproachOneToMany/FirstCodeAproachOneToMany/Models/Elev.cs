using System.ComponentModel.DataAnnotations;

namespace FirstCodeAproachOneToMany.Models
{
    public class Elev
    {
        [Key]

        public int ElevID { get; set; }

        [MaxLength(50), MinLength(3)]

        public string ElevNume { get; set; } = null!;

        public DateTime? DataNasterii { get; set; }

        public int ClasaID { get; set; }    

        public Clasa? Clasa { get; set; }
    }
}