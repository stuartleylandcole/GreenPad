using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using GreenPad.Entities;

namespace GreenPad.Mappings
{
    public class ProjectMap : ClassMap<Project>
    {
        public ProjectMap()
        {
            Id(x => x.KeyTable);
            Map(x => x.Name);
            Map(x => x.Description);
            HasMany(x => x.Tasks)
                .Inverse()
                .Cascade.All();
        }
    }
}
