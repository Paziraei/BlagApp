using System.ComponentModel.DataAnnotations;
namespace Models.Base
{
    public class User :BaseEntity
    {
        public User()
        {
        }
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(20)]
        public string NatiralCode { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(20)]
        public string UserName { get; set; }

        [MaxLength(20)]
        public string PassWord { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
        public List<TypeWork> TypeWorks { get; set; }

    }
}
