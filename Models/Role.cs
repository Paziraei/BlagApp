using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Role :Base.BaseEntity
    {
        public Role()
        {
        }
        [MaxLength(20)]
        public string Name { get; set; }
        public List<UserRole> UserRoles { get; set; } 

    }
}
