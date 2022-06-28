using Microsoft.EntityFrameworkCore;

namespace Blog.Models {
     public class Posts {
          public int Id { get; set; }
          public string Title { get; set; }
          public string Content { get; set; }
          public DateTime CreationDate { get; set; }

          public int UserId { get; set; }
          public Users User { get; set; }

          public List<Categories> Categories { get; set; }
     }
}
