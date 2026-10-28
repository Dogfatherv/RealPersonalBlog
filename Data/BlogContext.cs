using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RealPersonalBlog.Models;
namespace RealPersonalBlog.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(
            DbContextOptions<BlogContext> options) : base(options) { }





    
        
    public DbSet<BlogPost> BlogPosts { get; set; }
        = null!;
    }
}


