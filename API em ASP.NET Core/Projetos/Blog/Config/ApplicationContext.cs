using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Config {
     public class ApplicationContext : DbContext {
          
          public ApplicationContext(DbContextOptions<ApplicationContext> options) :base(options) {
               Database.EnsureCreated();
          }

          public DbSet<Users> Users { get; set; }
          public DbSet<Categories> Categories { get; set; }
          public DbSet<Blog.Models.Posts>? Posts { get; set; }
          public DbSet<Blog.Models.Comments>? Comments { get; set; }
     }
}
