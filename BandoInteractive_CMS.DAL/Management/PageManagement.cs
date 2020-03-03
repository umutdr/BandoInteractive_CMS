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

        public Page GetById(int pageId)
        {
            Page page = dataContext.Pages.SingleOrDefault(x => x.Id == pageId);

            return page;
        }

        public List<Page> GetAll()
        {
            List<Page> pageList = dataContext.Pages.ToList();

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
