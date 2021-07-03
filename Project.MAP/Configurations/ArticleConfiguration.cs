using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.MAP.Configurations
{
    public class ArticleConfiguration:BaseConfiguration<Article>
    {
        public override void Configure(EntityTypeBuilder<Article> builder)
        {
            base.Configure(builder);
        }
    }
}
