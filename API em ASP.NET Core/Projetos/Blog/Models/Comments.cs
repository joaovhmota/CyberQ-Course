namespace Blog.Models {
     public class Comments {
          public int Id { get; set; }
          public string Title { get; set; }
          public string Content { get; set; }
          public string CreatedAt { get; set; }

          public int UserId { get; set; }

          public int PostId { get; set; }
     }
}
