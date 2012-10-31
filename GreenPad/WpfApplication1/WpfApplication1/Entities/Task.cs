using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenPad.Entities
{
    public class Task
    {
        public virtual int KeyTable { get; private set; }
        public virtual Project Project { get; set; }
        public virtual string Description { get; set; }
        public virtual string Notes { get; set; }
        public virtual DateTime DateDue { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual bool Done { get; set; }
    }
}
