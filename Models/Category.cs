using System.ComponentModel.DataAnnotations;
namespace Models.Base
{
    public class Category : BaseEntity
    {
        public Category()
        {
        }
        public List<Post> Posts { get; set; }

        [MaxLength(50)]
        public string Name { get; set; } 
    }
}
