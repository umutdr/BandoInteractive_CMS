using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace BandoInteractive_CMS.Entity.Entities
{
    public class Page
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string URL { get; set; }

        [Required]
        [ForeignKey(nameof(Layout))]
        public int LayoutId { get; set; }

        public Layout Layout { get; set; }

        [Required]
        [ForeignKey(nameof(ParentPage))]
        public int ParentPageId { get; set; }

        public Page ParentPage { get; set; }

        public IQueryable<Page> ChildPages { get; set; }
    }

}
