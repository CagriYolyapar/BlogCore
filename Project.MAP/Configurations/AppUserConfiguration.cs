﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.MAP.Configurations
{
    public class AppUserConfiguration:BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.Profile).WithOne(x => x.AppUser).HasForeignKey<AppUserProfile>(x => x.ID);
            builder.Ignore(x => x.ID);
        }
    }
}
