using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.ComponentModel.DataAnnotations;

namespace FirstCodeAproachOneToMany.Models
{
    public class Clasa
    {
        [Key]

        public int ClasaID {  get; set; }

        [MaxLength(10)]
        public string Denumire { get; set; } = null!;

        public int? NrElevi {  get; set; } 

        public ICollection<Elev>? Elevi { get; set; }

    }
}
