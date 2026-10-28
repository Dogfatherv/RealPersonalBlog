using System.ComponentModel.DataAnnotations;

namespace RealPersonalBlog.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }="";

        [Required]
        public string content { get; set; }="content";

        [StringLength(50)]
        public string Category { get; set; }="";

        public DateTime PublishedDate { get; set; }

        public bool IsPublished { get; set; }
    }
}
