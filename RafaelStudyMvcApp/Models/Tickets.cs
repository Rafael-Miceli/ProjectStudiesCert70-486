using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RafaelStudyMvcApp.Models
{
    public class Tickets
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Condo { get; set; }
        public string Description { get; set; }
        public DateTime OpenedDate { get; set; }
    }
}