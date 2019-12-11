using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class BaseViewModel
    {
        // View title
        public string Title { get; set; } = "";
        

        // All columns, for display
        public JobFieldType Column { get; set; } = JobFieldType.All;
        public List<JobFieldType> Columns { get; set; }
    }
       
}
