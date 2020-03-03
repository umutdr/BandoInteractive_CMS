using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BandoInteractive_CMS.DAL.Database;
using System.Data.Entity;
using BandoInteractive_CMS.Entity.Entities;

namespace BandoInteractive_CMS.DAL.Management
{
    public class PageManagement
    {
        private DataContext dataContext;

        public PageManagement()
        {
            dataContext = new DataContext();
        }

        public bool Create(Page page)
        {
            dataContext.Pages.Add(page);
            var result = dataContext.SaveChanges();

            return result > 0;
        }

        public Page GetById(int? pageId)
        {
            Page page = dataContext.Pages.SingleOrDefault(x => x.Id == pageId);

            return page;
        }

        public Page GetByURL(string pageURL)
        {
            var page = dataContext.Pages.Include(x => x.Layout).SingleOrDefault(x => x.URL == pageURL);

            return page;
        }

        public IQueryable<Page> GetChildsById (int id)
        {
            var childPages = dataContext.Pages.Where(x => x.ParentPageId == id && x.Id != id);

            return childPages;
        }

        public List<Page> GetAll()
        {
            List<Page> pageList = dataContext.Pages.Include(p => p.Layout).Include(p => p.ParentPage).ToList();

            return pageList;
        }

        public bool Update(Page page)
        {
            dataContext.Entry(page).State = EntityState.Modified;
            var result = dataContext.SaveChanges();

            return result > 0;
        }

        public bool Delete(Page page)
        {
            dataContext.Pages.Remove(page);
            var result = dataContext.SaveChanges();

            return result > 0;

        }
    }
}
