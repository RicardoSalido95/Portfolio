namespace Portfolio.Models.Blog
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public string AuthorName { get; set; }  
        public int PostId { get; set; }
        public Post Post { get; set; }
        public bool IsApproved { get; set; }   
    }
}