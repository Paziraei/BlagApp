using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Category : Base.BaseEntity
    {
        public Category()
        {
        }
        public List<Post> Posts { get; set; }

        [MaxLength(50)]
        public string Name { get; set; } 
    }
}
