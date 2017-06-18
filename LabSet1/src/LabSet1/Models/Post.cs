using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LabSet1.Models
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }        public BlogDataContext(DbContextOptions<BlogDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
    public class Post
    {
        [Key]
        public long PostId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Blog post title")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Title must be between 5 and 100 characters long")]
        public string Title { get; set; }
        public DateTime PostedDate { get; set; }
        public string Author { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Blog post must be at least 5 characters long")]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
    }

    

}
