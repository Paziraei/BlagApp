using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class TypeWork :Base.BaseEntity
    {
        public TypeWork()
        {
        }
         [MaxLength(20)]
        public string Name { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public Post Post { get; set; }
        public int PostId { get; set; }
    }
}
