using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace Blogg.Models
{
    public partial class BloggingContext : DbContext
    {
        public virtual DbSet<PostModel> Post { get; set; }

        public BloggingContext(DbContextOptions<BloggingContext> options)
        : base(options)
        { }
    }
}
