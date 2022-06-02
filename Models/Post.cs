using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Post : Base.BaseEntity
    {
        public Post()
        {
        }
        public User User { get; set; }
        public int UserId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<Gallery> Galleries { get; set; }
        [MaxLength(50)]
        public string Titel { get; set; }
        public string Text { get; set; }
        public List<Comment> Comments { get; set; }
        public List<TypeWork> TypeWorks { get; set; }

    }
}
