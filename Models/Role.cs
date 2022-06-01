using System.ComponentModel.DataAnnotations;
namespace Models.Base
{
    public class Role :BaseEntity
    {
        public Role()
        {
        }
        [MaxLength(20)]
        public string Name { get; set; }
        public List<UserRole> UserRoles { get; set; } 

    }
}
