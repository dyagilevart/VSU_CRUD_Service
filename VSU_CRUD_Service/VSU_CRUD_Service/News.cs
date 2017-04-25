using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSU_CRUD_Service
{
    public class News
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
    }
}