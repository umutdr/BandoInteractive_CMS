using BandoInteractive_CMS.DAL.Management;
using BandoInteractive_CMS.Entity.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BandoInteractive_CMS.Service.Services
{
    public class PageServices
    {
        PageManagement pageManagement;

        public PageServices()
        {
            pageManagement = new PageManagement();
        }

        public bool Create(Page page)
        {
            var result = pageManagement.Create(page);

            return result;
        }

        public Page GetById(int? pageId)
        {
            Page page = pageManagement.GetById(pageId);

            return page;
        }

        public Page GetByURL(string pageURL)
        {
            Page page = pageManagement.GetByURL(pageURL);

            return page;
        }

        public IQueryable<Page> GetChildsById(int id)
        {
            var childPages = pageManagement.GetChildsById(id);

            return childPages;
        }

        public List<Page> GetAll()
        {
            List<Page> pageList = pageManagement.GetAll();

            return pageList;
        }

        public bool Update(Page page)
        {
            var result = pageManagement.Update(page);

            return result;
        }

        public bool Delete(Page page)
        {
            var result = pageManagement.Delete(page);

            return result;

        }

    }
}
