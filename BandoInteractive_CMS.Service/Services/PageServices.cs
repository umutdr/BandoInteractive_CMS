using BandoInteractive_CMS.DAL.Management;
using BandoInteractive_CMS.Entity.Entities;
using System.Collections.Generic;

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

        public Page GetById(int pageId)
        {
            Page page = pageManagement.GetById(pageId);

            return page;
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
