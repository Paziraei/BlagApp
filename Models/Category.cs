using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Category : Base.BaseEntity
    {
        public Category(string name) : base()
        {
            Name = name;
        }

        public List<Post>? Posts { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
