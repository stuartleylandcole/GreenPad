using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenPad.Entities
{
    public class Project
    {
        public virtual int KeyTable { get; private set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual IList<Task> Tasks { get; private set; }

        public Project()
        {
            Tasks = new List<Task>();
        }

        public virtual void AddTask(Task task)
        {
            Tasks.Add(task);
        }
    }
}
