using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.MAP.Configurations
{
    public class TagConfiguration:BaseConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> builder)
        {
            base.Configure(builder);
        }
    }
}
