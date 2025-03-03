using System.ComponentModel.DataAnnotations;

namespace TestCodeFirst.Models
{
    public class Elev
    {
        [Key]
        public int ElevID { get; set; }

        [MaxLength(50), MinLength(3)]
        public string Name { get; set; } = null!;

        [Required]
        public int Varsta { get; set; }

        public DateTime? DataNasterii { get; set; }

    }
}
