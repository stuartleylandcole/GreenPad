using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using GreenPad.Entities;

namespace GreenPad.Mappings
{
    public class TaskMap : ClassMap<Task>
    {
        public TaskMap()
        {
            Id(x => x.KeyTable);
            Map(x => x.Description);
            Map(x => x.Notes);
            Map(x => x.DateDue);
            Map(x => x.Done);
            References(x => x.Project);
            References(x => x.Priority);
        }
    }
}
