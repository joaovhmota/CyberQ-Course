namespace Blog.Models {
     public class Comments {
          public int Id { get; set; }
          public string Title { get; set; }
          public string Content { get; set; }
          public DateTime CreatedAt { get; set; }

          public int UserId { get; set; }
          public Users User { get; set; }

          public int PostId { get; set; }
          public Posts Post { get; set; }

     }
}
