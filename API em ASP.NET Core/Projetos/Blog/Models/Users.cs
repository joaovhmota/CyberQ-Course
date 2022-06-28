namespace Blog.Models {
     public class Users {
          public int Id { get; set; }
          public string Username { get; set; }
          public string Password { get; set; }
          public bool IsReader { get; set; }
          public bool IsEditor { get; set; }
          public bool IsAdmin { get; set; }

          public List<Posts> Posts { get; set; }
          public List<Comments> Comments { get; set; }
     }
}
