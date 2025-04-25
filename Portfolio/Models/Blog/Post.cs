namespace Portfolio.Models.Blog
{
    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string Content { get; set; }
        public string Slug { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool isPublish { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }           
        public List<Comment> Comments { get; set; } 
        public List<Tag> Tags { get; set; }       
        public string MetaTitle { get; set; }      
        public string MetaDescription { get; set; }
    }
}
