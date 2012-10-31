using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenPad.Entities
{
    public class Priority
    {
        public virtual int KeyTable { get; private set; }
        public virtual string Description { get; set; }
        public virtual int Value { get; set; }
    }
}
