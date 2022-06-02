using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Comment: Base.BaseEntity
    {
        public Comment()
        {
        }
       
        public string Text { get; set; }
        public string Post { get; set; }
        public int PostId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
