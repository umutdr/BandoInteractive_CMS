using BandoInteractive_CMS.DAL.Database;
using BandoInteractive_CMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandoInteractive_CMS.DAL.Management
{
    public class LayoutManagement
    {
        private DataContext dataContext;

        public LayoutManagement()
        {
            dataContext = new DataContext();
        }

        public bool Create(Layout layout)
        {
            dataContext.Layouts.Add(layout);
            var result = dataContext.SaveChanges();

            return result > 0;
        }

        public Layout GetById(int? layoutId)
        {
            Layout layout = dataContext.Layouts.SingleOrDefault(x => x.Id == layoutId);

            return layout;
        }

        public List<Layout> GetAll()
        {
            List<Layout> layoutList = dataContext.Layouts.ToList();

            return layoutList;
        }

        public bool Update(Layout layout)
        {
            dataContext.Entry(layout).State = EntityState.Modified;
            var result = dataContext.SaveChanges();

            return result > 0;
        }

        public bool Delete(Layout layout)
        {
            dataContext.Layouts.Remove(layout);
            var result = dataContext.SaveChanges();

            return result > 0;

        }
    }
}
