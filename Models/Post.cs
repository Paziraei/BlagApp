namespace Models.Base
{
    public class Post : BaseEntity
    {
        public Post()
        {
        }
        public User User { get; set; }
        public int UserId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<Gallery> Galleries { get; set; }
        public string Titel { get; set; }
        public string Text { get; set; }
        public List<Comment> Comments { get; set; }
        public List<TypeWork> TypeWorks { get; set; }

    }
}
