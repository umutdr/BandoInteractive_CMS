using BandoInteractive_CMS.DAL.Management;
using BandoInteractive_CMS.Entity.Entities;
using System.Collections.Generic;

namespace BandoInteractive_CMS.Service.Services
{
    public class LayoutServices
    {
        LayoutManagement layoutManagement;

        public LayoutServices()
        {
            layoutManagement = new LayoutManagement();
        }

        public bool Create(Layout layout)
        {
            var result = layoutManagement.Create(layout);

            return result;
        }

        public Layout GetById(int layoutId)
        {
            Layout layout = layoutManagement.GetById(layoutId);

            return layout;
        }

        public List<Layout> GetAll()
        {
            List<Layout> layoutList = layoutManagement.GetAll();

            return layoutList;
        }

        public bool Update(Layout layout)
        {
            var result = layoutManagement.Update(layout);

            return result;
        }

        public bool Delete(Layout layout)
        {
            var result = layoutManagement.Delete(layout);

            return result;

        }
    }
}
