using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.utils
{
    class Task
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public EnumStatus Status { get; set; }
        public string Type { get; set; }
        public bool TODO { get; set; }

        public Task(int id, string name, EnumStatus status, string type, bool todo)
        {
            ID = id;
            ProjectName = name;
            Status = status;
            Type = type;
            TODO = todo;
        }

    }
}
