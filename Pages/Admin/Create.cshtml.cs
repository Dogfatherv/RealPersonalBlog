using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using RealPersonalBlog.Data;
using RealPersonalBlog.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace RealPersonalBlog.Pages.Admin
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly BlogContext _Context;

        public CreateModel(BlogContext context)
        {
            _Context = context;
        }

        public BlogPostInput Input { get; set; } = new BlogPostInput();

        public void OnGet()
        {
            
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var post = new BlogPost
            {
                Title = Input.Title,
                content = Input.content,
                Category = Input.Category,
                PublishedDate = DateTime.UtcNow,
                IsPublished = Input.Ispublished

            };

            _Context.BlogPosts.Add(post);

            await _Context.SaveChangesAsync();

            return RedirectToPage("/Blog");

        }
        public class BlogPostInput
        {
            [Required(ErrorMessage = "Please enter a title.")]
            [StringLength(150)]
            public string Title { get; set; } = "";

            [Required(ErrorMessage = "Please write your article.")]

            public string content { get; set; } = "";

            [Required(ErrorMessage = "Please select a category.")]

            public string Category { get; set; } = "";
            public bool Ispublished { get; set; }

        }
    }
}
