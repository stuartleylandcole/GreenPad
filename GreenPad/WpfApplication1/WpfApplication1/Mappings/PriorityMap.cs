using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using GreenPad.Entities;

namespace GreenPad.Mappings
{
    public class PriorityMap : ClassMap<Priority>
    {
        public PriorityMap()
        {
            Id(x => x.KeyTable);
            Map(x => x.Description);
            Map(x => x.Value);
        }
    }
}
