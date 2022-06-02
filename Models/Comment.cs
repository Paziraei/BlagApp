using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Comment: Base.BaseEntity
    {
        public Comment(string text)
        {
            Text = text;
        }
       
        [Required]
        public string Text { get; set; }

        public Post Post { get; set; }
        public int PostId { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
    }
}
