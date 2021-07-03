using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.MAP.Configurations
{
    public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : class,IEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.CreatedDate).HasColumnName("Yaratilma Tarihi");
            builder.Property(x => x.ModifiedDate).HasColumnName("Güncelleme tarihi");
            builder.Property(x => x.DeletedDate).HasColumnName("Silme Tarihi");
        }
    }
}
