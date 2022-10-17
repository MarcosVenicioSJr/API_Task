using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Task.Models
{
    public class TaskModels
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public EnumTask Status { get; set; }

    }
}
