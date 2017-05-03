using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace VSU_CRUD_Service
{
    public class Service1 : IService1
    {

        public News find(string id)
        {
            using (DatabaseEntities de = new DatabaseEntities())
            {
                return de.Table.Where(pe => pe.Id.ToString() == id).Select(pe => new News
                {
                    Id = pe.Id.ToString(),
                    Title = pe.Title,
                    Description = pe.Description,
                    Author = pe.Author,
                    Date = pe.Date.ToString(),
                    Type = pe.Type
                }).First();
            };
        }

        public List<News> findAll()
        {
            using (DatabaseEntities de = new DatabaseEntities())
            {
                return de.Table.Select(pe => new News
                {
                    Id = pe.Id.ToString(),
                    Title = pe.Title,
                    Description = pe.Description,
                    Author = pe.Author,
                    Date = pe.Date.ToString(),
                    Type = pe.Type
                }).ToList();
            };
        }
}
}

