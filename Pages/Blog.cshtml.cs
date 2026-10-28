using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealPersonalBlog.Data;
using RealPersonalBlog.Models;
using SQLitePCL;


namespace RealPersonalBlog.Pages
{
    public class BlogModel : PageModel
    {
        private readonly BlogContext _context;
        private bool BlogModelIsPublished;

        public BlogModel(BlogContext context)
        {
            _context = context;
        }

        public IList<BlogPost> Posts { get; set; }
        = new List<BlogPost>();

        // Ensure the method signature has 'async' and returns a 'Task'
        public async Task OnGetAsync()
        {
            Posts = await _context.BlogPosts
                .Where(posts => posts.IsPublished)
                .OrderByDescending(posts => posts.PublishedDate)
                .ToListAsync();
        }

    }
}
