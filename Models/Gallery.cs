using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Gallery : Base.BaseEntity
    {
        public Gallery()
        {
        }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string Type { get; set; }

        public Post Post { get; set; }
        public int PostId { get; set; }
    }
}
