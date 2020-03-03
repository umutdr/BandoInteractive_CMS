using System.ComponentModel.DataAnnotations;

namespace BandoInteractive_CMS.Entity.Entities
{
    public class Layout
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Path { get; set; }
    }
}