using System.Linq;

namespace BandoInteractive_CMS.Entity.Entities
{
    public class Page
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public string URL { get; set; }

        public int LayoutId { get; set; }

        public Layout Layout { get; set; }

        public int ParentPageId { get; set; }

        public Page ParentPage { get; set; }

        public IQueryable<Page> ChildPages { get; set; }
    }

}
