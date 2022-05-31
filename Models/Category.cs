
namespace Models.Base
{
    public class Category : BaseEntity
    {
        public Category()
        {
        }
        public List<Post> Posts { get; set; }
        public string Name { get; set; } 
    }
}
