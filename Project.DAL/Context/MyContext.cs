using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.ENTITES.Models;
using Project.MAP.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Context
{
    public class MyContext:IdentityDbContext<AppUser,IdentityRole<int>,int>
    {
        public MyContext(DbContextOptions<MyContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new ProfileConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new TagConfiguration());
            builder.ApplyConfiguration(new ArticleConfiguration());
            builder.ApplyConfiguration(new ArticleTagConfiguration());
            builder.ApplyConfiguration(new EditorConfiguration());
            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleTag> ArticleTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Editor> Editors { get; set; }
        public DbSet<AppUserProfile> Profiles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }


    }
}
