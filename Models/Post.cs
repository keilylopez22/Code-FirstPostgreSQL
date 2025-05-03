namespace CodeFirstAPI.Models
{
    public class Post
    {
        public int Id { get; set; }  // primary key
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}