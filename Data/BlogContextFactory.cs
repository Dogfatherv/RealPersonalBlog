using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RealPersonalBlog.Data
{
    
    public class BlogContextFactory
    
    {
        public class  RealPersonalBlog: IDesignTimeDbContextFactory<BlogContext>
        {
            public BlogContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<BlogContext>();

                // Replace with your actual database provider and connection string
                optionsBuilder.UseSqlite("Data Source=RealPersonalBlogDb.db");

                return new BlogContext(optionsBuilder.Options);
            }
        }
    }

}

